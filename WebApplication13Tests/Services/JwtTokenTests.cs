using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace WebApplication13.Services.Tests
{
    [TestClass()]
    public class JwtTokenTests
    {
        [TestMethod()]
        public void test_CreateTokenForUserTest_ClaimToken()
        {
            // Arrange
            string user = "test";
            var jwtTokenService = TestJwt.GetJwtTokenService();

            // Act
            var result_jwt = jwtTokenService.CreateTokenForUser(user);
            var result = jwtTokenService.ClaimToken(result_jwt);
            // Assert
            Assert.AreEqual(result, user);
        }
    }
}