using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication13.Dtos;
using WebApplication13.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication13.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Cog1Controller : ControllerBase
    {
        private readonly ICog1Service _cog1Service;
        public Cog1Controller(ICog1Service cog1Service)
        {
            _cog1Service = cog1Service;
        }
        // GET: api/<Cog1Controller>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Get()
        {
            return await _cog1Service.Get();
        }
        // GET api/<Cog1Controller>/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<IActionResult> Get(int id)
        {
            return await _cog1Service.Get(id);
        }
        // POST api/<Cog1Controller>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Post([FromBody] TbItemTypeDto value)
        {
            return await _cog1Service.Post(value);
        }

        // PUT api/<Cog1Controller>/5
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> Put(int id, [FromBody] TbItemTypeDto value)
        {
            return await _cog1Service.Put(id,value);
        }
        // DELETE api/<Cog1Controller>/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            return await _cog1Service.Delete(id);
        }
    }
}
