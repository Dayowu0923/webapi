using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using WebApplication13.Models;

namespace WebApplication13.Services
{
    public interface IAuthenticationService
    {
        IActionResult Login(LoginModel login);
    }
    public class LoginService : IAuthenticationService
    {
        private readonly IDistributedCache _cache;
        private readonly _2023gtafContext _gtafContext;
        private readonly IJwtToken _auth;
        public LoginService(IDistributedCache cache, _2023gtafContext gtafContext, IJwtToken auth)
        {
            _cache = cache;
            _gtafContext = gtafContext;
            _auth = auth;
        }

        public IActionResult Login(LoginModel login)
        {
            string captchaValue = _cache.GetString("CaptchaCode");
            if (login.Captcha != captchaValue)
            {
                return new BadRequestObjectResult("無效的驗證碼");
            }

            var user = _gtafContext.TbUsers
                .FirstOrDefault(u => u.UserNo == login.Username && u.UserPwd == login.Password);

            if (user == null)
            {
                return new UnauthorizedObjectResult("用戶名或密碼錯誤");
            }

            var token = _auth.CreateTokenForUser(user.UserNo);
            if (token == null)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }

            var mainPermissions = (from menu in _gtafContext.CsTbMenus
                                   join permission in _gtafContext.CsTrPermissionUsers on menu.MenuId equals permission.MenuId
                                   join usertb in _gtafContext.TbUsers on permission.UserNo equals usertb.UserNo
                                   where usertb.UserNo == user.UserNo && menu.MenuLastId == 0
                                   select new
                                   {
                                       menu.MenuId,
                                       Menu = menu.MenuName,
                                       Sort = menu.MenuSort,
                                       MenuPath = menu.MenuUrl,
                                       menu.MenuIcon,
                                   }).OrderBy(p => p.Sort).ToList();

            var subPermissions = (from menu in _gtafContext.CsTbMenus
                                  join permission in _gtafContext.CsTrPermissionUsers on menu.MenuId equals permission.MenuId
                                  join usertb in _gtafContext.TbUsers on permission.UserNo equals usertb.UserNo
                                  where usertb.UserNo == user.UserNo && menu.MenuLastId != 0
                                  select new
                                  {
                                      menu.MenuId,
                                      Menu = menu.MenuName,
                                      menu.MenuIcon,
                                      menu.MenuLastId,
                                      MenuPath = menu.MenuUrl,
                                      Sort = menu.MenuSort
                                  }).OrderBy(p => p.Sort).ToList();

            if (subPermissions.Count == 0)
            {
                return new BadRequestObjectResult("帳號沒有權限");
            }

            return new OkObjectResult(new { Token = token, MainPer = mainPermissions, SubPer = subPermissions });
        }
    }
}
