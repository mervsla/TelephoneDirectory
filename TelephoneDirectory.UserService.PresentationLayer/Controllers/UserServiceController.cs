using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelephoneDirectory.UserService.BusinessLayer.DTOs;
using TelephoneDirectory.UserService.BusinessLayer.Managers;

namespace TelephoneDirectory.UserService.PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserServiceController : Controller
    {

        IUserManager userManager;
        IContactManager contactManager;
        public UserServiceController(IUserManager _userManager,IContactManager _contactManager)
        {
            userManager = _userManager;
            contactManager = _contactManager;

        }
        public IActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public void AddUser(UserDto userDto)
        {
            Guid guid = Guid.NewGuid();
            userDto.UserID = guid;
            userManager.AddUser(userDto);
        }
        [HttpPost]
        public void DeleteUser(Guid userId)
        {
            contactManager.DeleteContact(userId);
            userManager.DeleteUser(userId);
           
        }
        public void AddContact(ContactDto contactDto)
        {
            contactManager.AddContact(contactDto);
        }

        public List<UserDto> getAllUsersContacts()
        {
            return userManager.getAllUsersContacts();
        }


    }
}
