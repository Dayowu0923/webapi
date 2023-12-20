using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication13.Models;
using AutoMapper;
using WebApplication13.Dtos;
using WebApplication13.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication13.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CogItemController : ControllerBase
    {
        private readonly _2023gtafContext _gtafContext;
        private readonly IMapper _imapper;
        private readonly JwtToken _auth;
        private readonly CogItemService _cogItem;
        public CogItemController(_2023gtafContext gtafContext, IMapper imapper, JwtToken auth, CogItemService cogItem)
        {
            _gtafContext = gtafContext;
            _imapper = imapper;
            _auth = auth;
            _cogItem = cogItem;
        }

        // GET: api/<CogItem>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Get()
        {
            return await _cogItem.Get();
        }

        // GET api/<CogItem>/5
        [HttpGet("{id}")]

        public async Task<IActionResult> Get(int id)
        {

            return await _cogItem.Get(id);
        }

        // POST api/<CogItem>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Post([FromBody] TbItemCodeDto value)
        {
            return await _cogItem.Post(value);
        }

        // PUT api/<CogItem>/5
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> Put(int id, [FromBody] TbItemCodeDto value)
        {
            return await _cogItem.Put(id,value);
        }
        // DELETE api/<CogItem>/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            return await _cogItem.Delete(id);
        }
    }
}
