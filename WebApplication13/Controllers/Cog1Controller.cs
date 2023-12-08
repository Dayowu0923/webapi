using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication13.Models;
using AutoMapper;
using WebApplication13.Dtos;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using WebApplication13.Profiles;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication13.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Cog1Controller : ControllerBase
    {
        private readonly _2023gtafContext _gtafContext;
        private readonly IMapper _imapper;
        private readonly JwtToken _auth;
        public Cog1Controller(_2023gtafContext gtafContext, IMapper imapper, JwtToken auth)
        {
            _gtafContext = gtafContext;
            _imapper = imapper;
             _auth = auth;
        }

        // GET: api/<Cog1Controller>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Get()
        {
            var item = await (from tbl in _gtafContext.TbItemTypes
                                where tbl.Status == true
                                select new
                                {
                                    Id = tbl.Id,
                                    No = tbl.No,
                                    Name = tbl.Name,
                                    Udate = tbl.Udate.HasValue ? tbl.Udate.Value.ToString("yyyy-MM-dd HH:mm:ss") : "",
                                    Uuser = tbl.Uuser,
                                }
                     ).ToListAsync();
            return Ok(item);

            //var items = _gtafContext.TbItemTypes.Where(tbl => tbl.Status == true).ToList();
            //var itemDtos = _imapper.Map<List<TbItemCodeDto>>(items);

            //return Ok(itemDtos);
        }
   
        // GET api/<Cog1Controller>/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<IActionResult> Get(int id)
        {
            var item = await(from tbl in _gtafContext.TbItemTypes
                             where tbl.Status == true
                             select new
                             {
                                 Id = tbl.Id,
                                 No = tbl.No,
                                 Name = tbl.Name,
                                 Udate = tbl.Udate.HasValue ? tbl.Udate.Value.ToString("yyyy-MM-dd HH:mm:ss") : "",
                                 Uuser = tbl.Uuser,
                             }
                   ).FirstOrDefaultAsync();
           
            if (item == null)
            {
                return BadRequest("找不到資料");
            }
            return Ok(item);
        }

        // POST api/<Cog1Controller>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Post([FromBody] TbItemCodeDto value)
        {
            var token = HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            string user = _auth.ClaimToken(token);
            var config = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
            var mapper = config.CreateMapper();
            TbItemType entity = mapper.Map<TbItemType>(value);
            entity.Cuser = user;
            entity.Uuser = user;
            _gtafContext.TbItemTypes.Add(entity);
            await _gtafContext.SaveChangesAsync();
            return Ok();
        }

        // PUT api/<Cog1Controller>/5
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> Put(int id, [FromBody] TbItemCodeDto value)
        {
            var token = HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            string user = _auth.ClaimToken(token);
            if (id != value.Id)
            {
                return BadRequest();
            }
            var item = await _gtafContext.TbItemTypes.FindAsync(id);
            if(item == null)
            {
                return NotFound("找不到資料");
            }
            item.Udate = DateTime.Now;
            item.Uuser = user;
            item.Name = value.Name;
            item.No = value.No;
            await _gtafContext.SaveChangesAsync();
            return NoContent();
        }
        // DELETE api/<Cog1Controller>/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _gtafContext.TbItemTypes.FindAsync(id);
            if (item == null)
            {
                return NotFound("找不到資料");
            }
            item.Status = false;
            await _gtafContext.SaveChangesAsync();
            return NoContent();
        }
    }
}
