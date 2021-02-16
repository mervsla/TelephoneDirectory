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
        private UserServiceContext _ccontext;
        public ContactRepository(UserServiceContext context) : base(context)
        {
            _ccontext = context;
        }

        public void AddContact(Contact contact)
        {
            _ccontext.Contacts.Add(contact);
        }
        public Contact getContactByUserId(Guid userId)
        {
                Contact contact = _ccontext.Contacts.FirstOrDefault(x => x.UserID == userId);
                return contact;
        }
        public void DeleteContact(Contact contact)
        {
            try
            {
                _ccontext.Contacts.Remove(contact);
            }
            catch
            {
                
            }
            
        }
        public List<Contact> getAllContacts()
        {
            return _ccontext.Contacts.ToList();
        }

    }
}
