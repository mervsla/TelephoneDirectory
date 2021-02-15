using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.UserService.DataAccessLayer.Entities;

namespace TelephoneDirectory.UserService.DataAccessLayer.Repositories.Abstract
{
    public interface IContactRepository: IRepository<Contact>
    {
        void AddContact(Contact contact);
    }
}
