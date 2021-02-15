﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TelephoneDirectory.UserService.DataAccessLayer.Entities
{
   public class Contact
    {
        public int ID { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Guid UserID { get; set; }
        public User User { get; set; }
    }
}
