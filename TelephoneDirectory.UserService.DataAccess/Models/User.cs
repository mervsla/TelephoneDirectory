using System;
using System.Collections.Generic;
using System.Text;

namespace TelephoneDirectory.UserService.DataAccess.Models
{
    public class User
    {
        public User()
        {
            contacts = new List<Contact>();
        }
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CompanyName { get; set; }

        public ICollection<Contact> contacts { get; set; }
    }
}
