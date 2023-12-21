using Microsoft.Extensions.Caching.Distributed;
using SkiaSharp;

namespace WebApplication13.Services
{
    public interface ICaptchaService
    {
        byte[] GetCaptcha();
    }
    public class CaptchaService: ICaptchaService
    {
        private readonly IDistributedCache _cache;
        public CaptchaService(IDistributedCache cache)
        {
            _cache = cache;
        }
        public byte[] GetCaptcha()
        {
            var (captchaCode, captchaImage) = GenerateCaptcha();
            CacheCaptchaCode(captchaCode);
            return captchaImage;
        }

        private (string CaptchaCode, byte[] CaptchaImage) GenerateCaptcha()
        {
            string captchaCode = GenerateRandomCode();
            byte[] captchaImage = GenerateCaptchaImage(captchaCode);
            return (captchaCode, captchaImage);
        }
        private string GenerateRandomCode(int length = 6)
        {
            var random = new Random();
            //var code = new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
            //.Select(s => s[random.Next(s.Length)]).ToArray());
            var code = new string(Enumerable.Repeat("0123456789", length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
            return code;
        }
        private void CacheCaptchaCode(string captchaCode)
        {
            var options = new DistributedCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromMinutes(5));
            _cache.SetStringAsync("CaptchaCode", captchaCode, options);
        }
        private byte[] GenerateCaptchaImage(string code)
        {
            int width = 200;
            int height = 50;
            using (var surface = SKSurface.Create(new SKImageInfo(width, height)))
            {
                var canvas = surface.Canvas;
                canvas.Clear(SKColors.White);

                var paint = new SKPaint
                {
                    Color = SKColors.Black,
                    TextSize = 36,
                    IsAntialias = true,
                    Style = SKPaintStyle.Fill,
                    TextAlign = SKTextAlign.Center
                };

                var random = new Random();
                for (int i = 0; i < code.Length; i++)
                {
                    float x = 20 + i * 30;
                    float y = 35 + random.Next(-10, 10);
                    float rotate = random.Next(-15, 15);
                    canvas.Save();
                    canvas.Translate(x, y);
                    canvas.RotateDegrees(rotate);
                    canvas.DrawText(code[i].ToString(), 0, 0, paint);
                    canvas.Restore();
                }
                for (int i = 0; i < 10; i++)
                {
                    paint.Color = new SKColor((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255));
                    canvas.DrawLine(random.Next(0, width), random.Next(0, height), random.Next(0, width), random.Next(0, height), paint);
                }

                using (var image = surface.Snapshot())
                using (var data = image.Encode(SKEncodedImageFormat.Jpeg, 100))
                using (var stream = new MemoryStream())
                {
                    data.SaveTo(stream);
                    return stream.ToArray();
                }
            }
        }
    }
}
