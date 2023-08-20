using System;
using System.Collections.Generic;
using System.Linq;

namespace AuthenticationService
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> users;

        public UserRepository()
        {
            this.users = new List<User>()
            {
                new User(){
                    Id = Guid.NewGuid(),
                    FirstName = "Dmitry",
                    LastName = "Evdokimov",
                    Email = "test@test.com",
                    Login = "test",
                    Password = "1234",
                    Role = new Role() {
                        Id = 1,
                        Name = "Пользователь"
                    }},

                new User(){
                    Id = Guid.NewGuid(),
                    FirstName = "Иван",
                    LastName = "Иванов",
                    Email = "ivan@gmail.com",
                    Password = "11111122222qq",
                    Login = "ivanov",
                    Role = new Role() {
                        Id = 2,
                        Name = "Администратор"
                    }},

                new User(){
                    Id = Guid.NewGuid(),
                    FirstName = "Оксана",
                    LastName = "Смирнова",
                    Email = "oksana@test.ru",
                    Login = "oks",
                    Password = "1234",
                    Role = new Role() {
                        Id = 1,
                        Name = "Пользователь"
                    }}
            };
        }

        public IEnumerable<User> GetAll()
        {
            return users;
        }

        public User GetByLogin(string login)
        {
            return users.FirstOrDefault(user => user.Login == login);
        }
    }
}
