﻿using System;
using System.Linq;

namespace CleanCode.PoorMethodSignatures
{
    public class PoorMethodSignatures
    {
        public void Run()
        {
            var userService = new UserService();

            var user = userService.AuthenticateUser("username", "password");
            var anotherUser = userService.GetUserByUsername("username");
        }
    }

    public class UserService
    {
        private UserDbContext _dbContext = new UserDbContext();
        
        public User GetUserByUsername(string username)
        {
            return _dbContext.Users.SingleOrDefault(u => u.Username == username);
        }

        public User AuthenticateUser(string username, string password)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
                user.LastLogin = DateTime.Now;
            return user;
        }
    }

    public class UserDbContext : DbContext
    {
        public IQueryable<User> Users { get; set; }
    }

    public class DbSet<T>
    {
    }

    public class DbContext
    {
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
