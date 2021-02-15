using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.UserService.BusinessLayer.DTO;
using TelephoneDirectory.UserService.DataAccessLayer.Entities;
using TelephoneDirectory.UserService.DataAccessLayer.UOW;
using TelephoneDirectory.UserService.DataAccessLayer.USContext;

namespace TelephoneDirectory.UserService.BusinessLayer.Managers
{
  public class ContactManager
    {
        UnitOfWork uow = new UnitOfWork(new UserServiceContext());
        public Contact ConvertToContact(UserContactDto contactDto)
        {
            Contact contact = new Contact();
            contact.UserID = contactDto.UserID;
            contact.PhoneNumber = contactDto.PhoneNumber;
            contact.Email = contactDto.Email;
            contact.Address = contactDto.Address;

            return contact;
        }

        public void AddContact(UserContactDto contactDto)
        {
            Contact contact = ConvertToContact(contactDto);
            uow.ContactRepository.AddContact(contact);
            uow.Save();
        }
    }
}
