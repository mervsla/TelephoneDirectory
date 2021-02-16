using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.UserService.BusinessLayer.DTOs;

namespace TelephoneDirectory.UserService.BusinessLayer.Managers
{
    public interface IContactManager
    {
        void AddContact(ContactDto contactDto);
        void DeleteContact(Guid userId);
        ContactDto getContactByUserId(Guid userId);
    }
}
