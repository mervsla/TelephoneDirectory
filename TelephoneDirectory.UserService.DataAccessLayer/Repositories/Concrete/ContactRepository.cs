using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
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
        public Contact getContactByUserId(Guid userId)
        {
            return _context.Contacts.Where(x => x.UserID == userId).FirstOrDefault();
        }
        public void DeleteContact(Contact contact)
        {
            _context.Contacts.Remove(contact);
        }
        public List<Contact> getAllContacts()
        {
            return _context.Contacts.ToList();
        }

    }
}
