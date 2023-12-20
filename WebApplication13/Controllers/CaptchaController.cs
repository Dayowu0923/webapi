
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using WebApplication13.Services;

namespace WebApplication13.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CaptchaController : ControllerBase
    {

        private readonly IDistributedCache _cache;
        private readonly CaptchaService _captchaService;
        public CaptchaController(IDistributedCache cache, CaptchaService captchaService)
        {
            _cache = cache;
            _captchaService = captchaService;
        }
        [HttpGet]
        public IActionResult GetCaptcha()
        {
            var captchaImage = _captchaService.GetCaptcha();    
            return File(captchaImage, "image/jpeg");
        }
    }
}