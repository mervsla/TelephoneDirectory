using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.UserService.DataAccessLayer.Entities;

namespace TelephoneDirectory.UserService.DataAccessLayer.Repositories.Abstract
{
    public interface IContactRepository: IRepository<Contact>
    {
        void AddContact(Contact contact);
        Contact getContactByUserId(Guid userId);
        Contact getContactById(int contactId);
        void DeleteContact(Contact contact);
        List<Contact> getAllContacts();
        List<Contact> GetAllContactsById(Guid userId);
    }
}
