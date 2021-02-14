using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.UserService.DataAccess.Models;
using TelephoneDirectory.UserService.DataAccess.Repositories.Abstract;
using TelephoneDirectory.UserService.DataAccess.USContext;

namespace TelephoneDirectory.UserService.DataAccess.Repositories.Concrete
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
            throw new NotImplementedException();
        }

        public User AddUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
