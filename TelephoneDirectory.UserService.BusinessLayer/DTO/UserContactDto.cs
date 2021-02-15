using System;
using System.Collections.Generic;
using System.Text;

namespace TelephoneDirectory.UserService.BusinessLayer.DTO
{
   public class UserContactDto
    {
        public Guid UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
