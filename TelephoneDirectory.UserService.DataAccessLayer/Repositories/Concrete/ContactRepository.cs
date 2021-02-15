using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.UserService.DataAccessLayer.Entities;
using TelephoneDirectory.UserService.DataAccessLayer.Repositories.Abstract;
using TelephoneDirectory.UserService.DataAccessLayer.USContext;

namespace TelephoneDirectory.UserService.DataAccessLayer.Repositories.Concrete
{
   
    public class ContactRepository : Repository<Contact>, IContactRepository
    {
        private UserServiceContext _context;
        public ContactRepository(UserServiceContext context) : base(context)
        {
            _context = context;
        }

        public void AddContact(Contact contact)
        {
            _context.Contacts.Add(contact);
        }

       
    }
}
