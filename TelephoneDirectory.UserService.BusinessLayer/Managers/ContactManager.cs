using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.UserService.BusinessLayer.DTOs;
using TelephoneDirectory.UserService.DataAccessLayer.Entities;
using TelephoneDirectory.UserService.DataAccessLayer.UOW;
using TelephoneDirectory.UserService.DataAccessLayer.USContext;

namespace TelephoneDirectory.UserService.BusinessLayer.Managers
{
  public class ContactManager:IContactManager
    {
        UnitOfWork uow = new UnitOfWork(new UserServiceContext());
        public Contact ConvertToContact(ContactDto contactDto)
        {
            Contact contact = new Contact();
            contact.UserID = contactDto.UserID;
            contact.PhoneNumber = contactDto.PhoneNumber;
            contact.Email = contactDto.Email;
            contact.Address = contactDto.Address;

            return contact;
        }

        public void AddContact(ContactDto contactDto)
        {
            Contact contact = ConvertToContact(contactDto);
            uow.ContactRepository.AddContact(contact);
            uow.Save();
        }

        public void DeleteContact(Guid userId)
        {
            Contact contact = uow.ContactRepository.getContactByUserId(userId);
            uow.ContactRepository.DeleteContact(contact);
            uow.Save();
        }
    }
}
