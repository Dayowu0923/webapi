namespace WebApplication13.Services
{
    public class UserService
    {
        private readonly JwtToken _auth;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserService(JwtToken auth, IHttpContextAccessor httpContextAccessor)
        {
            _auth = auth;
            _httpContextAccessor = httpContextAccessor;
        }
        public string GetUser()
        {
            var user = "";
            var token = _httpContextAccessor.HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (token != null) 
            {
                user = _auth.ClaimToken(token);
            }
            return user;
        }
    }
}
