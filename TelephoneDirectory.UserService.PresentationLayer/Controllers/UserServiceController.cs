using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelephoneDirectory.UserService.BusinessLayer.DTO;
using TelephoneDirectory.UserService.BusinessLayer.Managers;

namespace TelephoneDirectory.UserService.PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        UserManager userManager = new UserManager();
        ContactManager contactManager = new ContactManager();

        [HttpPost]
        public void AddPerson(UserContactDto userContactDto)
        {
            Guid guid = Guid.NewGuid();
            userContactDto.UserID = guid;
            userManager.AddUser(userContactDto);
            contactManager.AddContact(userContactDto);
        }
    }
}
