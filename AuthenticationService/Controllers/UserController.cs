﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AuthenticationService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly ILogger logger;
        public UserController(ILogger logger, IMapper mapper)
        {
            this.logger = logger;
            this.mapper = mapper;

            //logger.WriteEvent("Сообщение о событии в программе");
            //logger.WriteError("Сообщение об ошибки в программе");
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

        [HttpGet]
        [Route("viewmodel")]
        public UserViewModel GetUserViewModel()
        {
            User user = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Иван",
                LastName = "Иванов",
                Email = "ivan@gmail.com",
                Password = "11111122222qq",
                Login = "ivanov"
            };

            var userViewModel = mapper.Map<UserViewModel>(user);

            return userViewModel;
        }
    }
}
