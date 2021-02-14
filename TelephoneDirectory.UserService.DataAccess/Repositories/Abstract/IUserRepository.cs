using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.UserService.DataAccess.Models;

namespace TelephoneDirectory.UserService.DataAccess.Repositories.Abstract
{
    public interface IUserRepository : IRepository<User>
    {
        User AddUser(User user);
    }
}
