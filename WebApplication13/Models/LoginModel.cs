namespace WebApplication13.Models
{
    public class LoginModel
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// 帳號
        /// </summary>
        public string Password { get; set; }
        /// 驗證碼
        /// </summary>
        public string Captcha { get; set; }
    }
}
