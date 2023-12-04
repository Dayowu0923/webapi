using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using WebApplication13.Models;

namespace WebApplication13.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IDistributedCache _cache;
        private readonly _2023gtafContext _gtafContext;
        private readonly JwtToken _auth;
        public LoginController(IDistributedCache cache, _2023gtafContext gtafContext , JwtToken auth)
        {
            _cache = cache;
            _gtafContext = gtafContext;
            _auth = auth;
        }
        [HttpPost]
        public IActionResult Login([FromBody] LoginModel login)
        {
            var result = _gtafContext.TbUsers.ToList();

            string captchaValue = _cache.GetString("CaptchaCode");
            if (login.Captcha != captchaValue)
            {
                return BadRequest("無效的驗證碼");
            }
            var user = _gtafContext.TbUsers
                .FirstOrDefault(u => u.UserNo == login.Username && u.UserPwd == login.Password);

            if (user == null)
            {
                return Unauthorized("用戶名或密碼錯誤");
            }
            var token = _auth.CreateTokenForUser(user.UserNo);
            if (token == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "無法生成令牌");
            }
            var mainPermissions = (from menu in _gtafContext.CsTbMenus
                                  join permission in _gtafContext.CsTrPermissionUsers on menu.MenuId equals permission.MenuId
                                  join usertb in _gtafContext.TbUsers on permission.UserNo equals usertb.UserNo
                                  where usertb.UserNo == user.UserNo  &&  menu.MenuLastId == 0
                                  select new
                                  {
                                      MenuId = menu.MenuId,
                                      Menu = menu.MenuName,
                                      Sort = menu.MenuSort,
                                      MenuPath = menu.MenuUrl,
                                      MenuIcon = menu.MenuIcon,
                                  }).OrderBy(p=> p.Sort).ToList();

            var subPermissions = (from menu in _gtafContext.CsTbMenus
                                  join permission in _gtafContext.CsTrPermissionUsers on menu.MenuId equals permission.MenuId
                                  join usertb in _gtafContext.TbUsers on permission.UserNo equals usertb.UserNo
                                  where usertb.UserNo == user.UserNo && menu.MenuLastId != 0
                                  select new
                                  {
                                      MenuId = menu.MenuId,
                                      Menu = menu.MenuName,
                                      MenuIcon = menu.MenuIcon,
                                      MenuLastId = menu.MenuLastId,
                                      MenuPath = menu.MenuUrl,
                                      Sort = menu.MenuSort
                                  }).OrderBy(p => p.Sort).ToList();

            if (subPermissions.Count == 0)
            {
                return BadRequest("帳號沒有權限");
            }
            return Ok(new { Token = token , MainPer = mainPermissions, SubPer = subPermissions });
        }
    }
}
