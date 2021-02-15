using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.UserService.DataAccessLayer.Entities;

namespace TelephoneDirectory.UserService.DataAccessLayer.Repositories.Abstract
{
    public interface IUserRepository : IRepository<User>
    {
        void AddUser(User user);
        User getUserByUserId(Guid userId);
        void DeleteUser(User user);
        List<User> getAllUsers();
    }
}
