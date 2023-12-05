using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication13.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication13.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Cog1Controller : ControllerBase
    {
        private readonly _2023gtafContext _gtafContext;
        public Cog1Controller(_2023gtafContext gtafContext)
        {
            _gtafContext = gtafContext;
        }

        // GET: api/<Cog1Controller>
        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            var item = (from tbl in _gtafContext.TbItemTypes where tbl.Status == true
                         select new {
                             Id = tbl.Id,
                             No = tbl.No,
                             Name = tbl.Name,
                             Udate = tbl.Udate,
                             Uuser = tbl.Uuser,
                         }
                         ).ToList().Select(u => new {
                             u.Id,
                             u.No,
                             u.Name,
                             Udate = u.Udate.HasValue ? u.Udate.Value.ToString("yyyy-MM-dd HH:mm:ss") : "",
                             u.Uuser
                         }).ToList(); 
            return Ok(item);
        }
        // GET api/<Cog1Controller>/5
        [HttpGet("{id}")]
        [Authorize]
        public IActionResult Get(int id)
        {
            var item = (from tbl in _gtafContext.TbItemTypes
                         where tbl.Status == true && tbl.Id == id
                         select new
                         {
                             Id = tbl.Id,
                             No = tbl.No,
                             Name = tbl.Name,
                             Udate = tbl.Udate,
                             Uuser = tbl.Uuser,
                         }
                        ).ToList().Select(u => new {
                            u.Id,
                            u.No,
                            u.Name,
                            Udate = u.Udate.HasValue ? u.Udate.Value.ToString("yyyy-MM-dd HH:mm:ss") : "",
                            u.Uuser
                        }).FirstOrDefault();
            if(item == null)
            {
                return BadRequest("找不到資料");
            }
            return Ok(item);
        }

        // POST api/<Cog1Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Cog1Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Cog1Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
