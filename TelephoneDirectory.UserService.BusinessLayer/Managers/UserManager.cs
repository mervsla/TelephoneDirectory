using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.UserService.BusinessLayer.DTO;
using TelephoneDirectory.UserService.DataAccessLayer.Entities;
using TelephoneDirectory.UserService.DataAccessLayer.UOW;
using TelephoneDirectory.UserService.DataAccessLayer.USContext;

namespace TelephoneDirectory.UserService.BusinessLayer.Managers
{
   public class UserManager
    {
        UnitOfWork uow = new UnitOfWork(new UserServiceContext());

        public User ConvertToUser(UserContactDto userDto)
        {
            User user = new User();
            user.ID = userDto.UserID;
            user.Name = userDto.Name;
            user.Surname = userDto.Surname;
            user.CompanyName = userDto.CompanyName;
            return user;
        }
        public void AddUser(UserContactDto userDto)
        {
            User user = ConvertToUser(userDto);
            uow.UserRepository.AddUser(user);
            uow.Save();
        }
       
    }
}
