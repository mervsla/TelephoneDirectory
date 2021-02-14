using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.UserService.DataAccess.Models;
using TelephoneDirectory.UserService.DataAccess.Repositories.Abstract;
using TelephoneDirectory.UserService.DataAccess.USContext;

namespace TelephoneDirectory.UserService.DataAccess.Repositories.Concrete
{
    public class UserRepository : Repository<User>,IUserRepository
    {
        private UserServiceContext _context;
        public UserRepository(UserServiceContext context) : base(context)
        {
            _context = context;
        }


        public User AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
    }


}
