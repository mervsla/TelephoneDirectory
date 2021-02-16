using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelephoneDirectory.UserService.BusinessLayer.DTOs;
using TelephoneDirectory.UserService.BusinessLayer.Managers;

namespace TelephoneDirectory.UserService.PresentationLayer.Controllers
{
    [Route("[controller]/[action]")]
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
        public void DeleteUser(UserDto userDto)
        {
            contactManager.DeleteContact(userDto.UserID);
            userManager.DeleteUser(userDto.UserID);
           
        }
        [HttpPost]
        public void AddContact(ContactDto contactDto)
        {
            contactManager.AddContact(contactDto);
        }

        [HttpGet]
        public List<UserDto> getAllUsersContacts()
        {
            List<UserDto> listusers= userManager.getAllUsersContacts();
            return listusers;
        }
        [HttpPost]
        public List<ContactDto> GetContact(ContactDto contactDto)
        {
            List<ContactDto> contact = new List<ContactDto>();
            contact.Add(contactManager.getContactByUserId(contactDto.UserID));
               
            return contact;
        }

    }
}
