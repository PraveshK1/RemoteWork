using Microsoft.AspNetCore.Mvc;
using Moq;
using RemoteWorker.Services.Abstract;
using RemoteWorker.Controllers;
using RemoteWorker.DTOs;
using Xunit;


namespace RemoteWorker.Tests
{
    public class UserControllerTests
    {
        [Fact]
        public async Task GetUser_ReturnsOkResult_WithUser()
        {
            // Arrange
            var mockUserService = new Mock<IUserService>();
            mockUserService
            .Setup(service => service.GetUserByIdAsync(It.IsAny<string>()))
            .ReturnsAsync(new UserDTO { Id = "1", FirstName = "Test User" });


            var controller = new UserController(mockUserService.Object);
            // Act
            var result = await controller.GetUser("1");
            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var user = Assert.IsType<UserDTO>(okResult.Value);
            Assert.Equal("1", user.Id);
            Assert.Equal("Test User", user.FirstName);
        }
    }
}
