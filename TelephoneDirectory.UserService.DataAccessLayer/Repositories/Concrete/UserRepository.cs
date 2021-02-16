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
        private UserServiceContext _ucontext;
        public UserRepository(UserServiceContext context) : base(context)
        {
            _ucontext = context;
        }


        public void AddUser(User user)
        {
            _ucontext.Users.Add(user);
        }

        public void DeleteUser(User user)
        {
            _ucontext.Users.Remove(user);
        }

        public User getUserByUserId(Guid userId)
        {
            return _ucontext.Users.Where(x => x.ID == userId).FirstOrDefault();
        }

        public List<User> getAllUsers()
        {
            return _ucontext.Users.ToList();
        }

        
    }


}
