using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.UserService.Core.DTO;
using TelephoneDirectory.UserService.DataAccess.Models;
using TelephoneDirectory.UserService.DataAccess.UOW;
using TelephoneDirectory.UserService.DataAccess.USContext;

namespace TelephoneDirectory.UserService.Core.Managers
{
  public class ContactManager
    {
        UnitOfWork uow = new UnitOfWork(new UserServiceContext());
        public Contact ConvertToContact(UserContactDto contactDto)
        {
            Contact contact = new Contact();
            contact.UserID = contactDto.UserID;
            contact.PhoneNumber = contactDto.PhoneNumber;
            contact.Email = contactDto.PhoneNumber;
            contact.Address = contactDto.Address;

            return contact;
        }

        public void AddContact(UserContactDto contactDto)
        {
            Contact contact = ConvertToContact(contactDto);
            uow.ContactRepository.AddContact(contact);
        }
    }
}
