using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.UserService.DataAccess.Models;

namespace TelephoneDirectory.UserService.DataAccess.Repositories.Abstract
{
    public interface IContactRepository: IRepository<Contact>
    {
        void AddContact(Contact contact);
    }
}
