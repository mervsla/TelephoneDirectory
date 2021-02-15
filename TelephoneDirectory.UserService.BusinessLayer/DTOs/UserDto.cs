using System;
using System.Collections.Generic;
using System.Text;

namespace TelephoneDirectory.UserService.BusinessLayer.DTOs
{
    public class UserDto
    {
        public UserDto()
        {
            contactDtos = new List<ContactDto>();
        }
        public Guid UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CompanyName { get; set; }
        public ICollection<ContactDto> contactDtos { get; set; }
    }
}
