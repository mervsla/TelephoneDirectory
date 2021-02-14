using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelephoneDirectory.UserService.Core.DTO;
using TelephoneDirectory.UserService.Core.Managers;
using TelephoneDirectory.UserService.DataAccess.Models;
using TelephoneDirectory.UserService.DataAccess.USContext;

namespace TelephoneDirectory.UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserServiceController : Controller
    {
       
        UserManager userManager = new UserManager();
        ContactManager contactManager = new ContactManager();

        [HttpPost]
        public void AddPerson(UserContactDto userContactDto)
        {
            Guid guid = Guid.NewGuid();
            userContactDto.UserID = guid;
            User user = userManager.AddUser(userContactDto);
            contactManager.AddContact(userContactDto);
        }
    }
}
