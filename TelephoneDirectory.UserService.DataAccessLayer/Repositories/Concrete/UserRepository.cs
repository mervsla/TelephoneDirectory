using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TelephoneDirectory.UserService.DataAccessLayer.Entities;
using TelephoneDirectory.UserService.DataAccessLayer.Repositories.Abstract;
using TelephoneDirectory.UserService.DataAccessLayer.USContext;

namespace TelephoneDirectory.UserService.DataAccessLayer.Repositories.Concrete
{
    public class UserRepository : Repository<User>,IUserRepository
    {
        private UserServiceContext _context;
        public UserRepository(UserServiceContext context) : base(context)
        {
            _context = context;
        }


        public void AddUser(User user)
        {
            _context.Users.Add(user);
        }

       
    }


}
