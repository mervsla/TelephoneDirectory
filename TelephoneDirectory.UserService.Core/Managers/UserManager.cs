using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.UserService.Core.DTO;
using TelephoneDirectory.UserService.DataAccess.Models;
using TelephoneDirectory.UserService.DataAccess.UOW;
using TelephoneDirectory.UserService.DataAccess.USContext;

namespace TelephoneDirectory.UserService.Core.Managers
{
   public class UserManager
    {
        UnitOfWork uow = new UnitOfWork(new UserServiceContext());

        public User ConvertToUser(UserContactDto userDto)
        {
            User user = new User();
            user.Name = userDto.Name;
            user.Surname = userDto.Surname;
            user.CompanyName = userDto.CompanyName;
            return user;
        }
        public User AddUser(UserContactDto userDto)
        {
            User user = ConvertToUser(userDto);
            uow.UserRepository.AddUser(user);
            return user;
        }
    }
}
