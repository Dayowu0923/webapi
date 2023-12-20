using Microsoft.Extensions.Caching.Distributed;
using WebApplication13.Models;
using Moq;
namespace WebApplication13.Services
{
    public class TestJwt
    {
        public static JwtToken GetJwtTokenService()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var distributedCacheMock = new Mock<IDistributedCache>();
            var gtafContextMock = new Mock<_2023gtafContext>();
            var httpContextAccessorMock = new Mock<IHttpContextAccessor>();
            var configurationMock = new Mock<IConfiguration>();

            configurationMock.Setup(x => x["Jwt:Key"]).Returns(configuration["Jwt:Key"]);
            configurationMock.Setup(x => x["Jwt:Issuer"]).Returns(configuration["Jwt:Issuer"]);
            configurationMock.Setup(x => x["Jwt:Audience"]).Returns(configuration["Jwt:Audience"]);

            return new JwtToken(
                configurationMock.Object,
                distributedCacheMock.Object,
                gtafContextMock.Object,
                httpContextAccessorMock.Object
            );
        }
    }
}
