
using System.Text;
using NUnit.Framework;
using Microsoft.Extensions.Caching.Distributed;
using WebApplication13.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
namespace WebApplication13.Services.Tests
{
    [TestFixture]
    public class LoginServiceTests
    {
        private LoginService _loginService;
        private Mock<_2023gtafContext> _gtafContextMock;
        private Mock<IJwtToken> _authMock;
        private Mock<IDistributedCache> _distributedCache;
        private BasicMockDbSet _basicDbSet ;
        [SetUp]
        public void Setup()
        { 
            _gtafContextMock = new Mock<_2023gtafContext>();
            _distributedCache = new Mock<IDistributedCache>();
            _authMock = new Mock<IJwtToken>();
            _loginService = new LoginService(_distributedCache.Object, _gtafContextMock.Object, _authMock.Object);
            _basicDbSet = new BasicMockDbSet();
        }

        [Test]
        public void Login_ValidUser_ReturnsOkObjectResult()
        {
            // Arrange
            var mockCsTbMenu = new List<CsTbMenu>
            {
                new CsTbMenu { MenuId = 1, MenuName = "Test", MenuSort = 1, MenuUrl = "Test", MenuIcon = "" , MenuLastId = 1 }
            };
            var mockTrPermissionUser = new List<CsTrPermissionUser>
            {
                new CsTrPermissionUser { Id = 1, MenuId = 1 , UserNo= "TestUser" },
            };
            var mockTbUsers = new List<TbUser>
            {
                new TbUser { SuNo = "tcepb",  UserNo= "TestUser" , UserPwd = "0000" },
            };
            var loginData = new LoginModel { 
                Password = "0000",
                Username = "TestUser",
                Captcha = "0000",
            };
            _distributedCache.Setup(_dis => _dis.Get(It.IsAny<string>()))
            .Returns(Encoding.UTF8.GetBytes("0000"));
            _authMock.Setup(_auth => _auth.CreateTokenForUser(It.IsAny<string>()))
                .Returns("AVASASQEGEW");
            _gtafContextMock.Setup(x => x.CsTbMenus).Returns(_basicDbSet.SetupDbSet(mockCsTbMenu));
            _gtafContextMock.Setup(x => x.CsTrPermissionUsers).Returns(_basicDbSet.SetupDbSet(mockTrPermissionUser));
            _gtafContextMock.Setup(x => x.TbUsers).Returns(_basicDbSet.SetupDbSet(mockTbUsers));

            // Act
            var result =  _loginService.Login(loginData);
            // Assert
            Assert.That(result, Is.InstanceOf<OkObjectResult>());
        }

      

    }
}