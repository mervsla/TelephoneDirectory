using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.UserService.DataAccessLayer.Entities;

namespace TelephoneDirectory.UserService.DataAccessLayer.Repositories.Abstract
{
    public interface IUserRepository : IRepository<User>
    {
        void AddUser(User user);
        //Guid getUserIdByMail(string email);
    }
}
