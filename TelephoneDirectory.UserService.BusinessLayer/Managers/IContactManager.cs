using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.UserService.BusinessLayer.DTOs;

namespace TelephoneDirectory.UserService.BusinessLayer.Managers
{
    public interface IContactManager
    {
        void AddContact(ContactDto contactDto);
        void DeleteContact(int contactId);
        void DeleteContactByUserId(Guid userId);
        ContactDto getContactByUserId(Guid userId);
        List<ContactDto> getAllContactsById(Guid userId);
        List<int> PersonPhoneCount(string address);
    }
}
