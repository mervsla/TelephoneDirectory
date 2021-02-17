using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.UserService.BusinessLayer.DTOs;

namespace TelephoneDirectory.UserService.BusinessLayer.Managers
{
   public interface IUserManager
    {
        void AddUser(UserDto userDto);

        void DeleteUser(Guid userId);
        List<UserDto> getAllUsersContacts();

    }
}
