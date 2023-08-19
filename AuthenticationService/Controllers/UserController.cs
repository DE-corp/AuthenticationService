using Microsoft.AspNetCore.Mvc;
using System;

namespace AuthenticationService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger logger;
        public UserController(ILogger logger)
        {
            this.logger = logger;

            logger.WriteEvent("Сообщение о событии в программе");
            logger.WriteError("Сообщение об ошибки в программе");
        }

        [HttpGet]
        public User GetUser()
        {
            return new User()
            {

                Id = Guid.NewGuid(),
                FirstName = "Dmitry",
                LastName = "Evdeokimov",
                Email = "test@test.com",
                Login = "test",
                Password = "1234"
            };
        }
    }
}
