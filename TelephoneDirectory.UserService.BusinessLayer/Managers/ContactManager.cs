using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TelephoneDirectory.UserService.BusinessLayer.DTOs;
using TelephoneDirectory.UserService.DataAccessLayer.Entities;
using TelephoneDirectory.UserService.DataAccessLayer.UOW;
using TelephoneDirectory.UserService.DataAccessLayer.USContext;

namespace TelephoneDirectory.UserService.BusinessLayer.Managers
{
    public class ContactManager : IContactManager
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
        public ContactDto ConvertToContactDto(Contact contact)
        {
            ContactDto contactDto = new ContactDto();
            try
            {

                contactDto.UserID = contact.UserID;
                contactDto.PhoneNumber = contact.PhoneNumber;
                contactDto.Email = contact.Email;
                contactDto.Address = contact.Address;
            }
            catch
            {
                contactDto = null;
            }
           

            return contactDto;
        }
        public void AddContact(ContactDto contactDto)
        {
            Contact contact = ConvertToContact(contactDto);
            uow.ContactRepository.AddContact(contact);
            uow.Save();
        }

        public ContactDto getContactByUserId(Guid userId)
        {
            ContactDto contactDto = ConvertToContactDto(uow.ContactRepository.getContactByUserId(userId));
            return contactDto;

        }

        public List<ContactDto> getAllContactsById(Guid userId)
        {
            List<ContactDto> contacts = uow.ContactRepository.GetAllContactsById(userId).Where(x=>x.UserID==userId).Select(y => new ContactDto
            {

                ID = y.ID,
                Email = y.Email,
                PhoneNumber = y.PhoneNumber,
                Address = y.Address,
                UserID = y.UserID


            }).ToList();

            return contacts;


        }


        public void DeleteContact(int contactId)
        {
            Contact contact = uow.ContactRepository.getContactById(contactId);
            uow.ContactRepository.DeleteContact(contact);
            uow.Save();
        }
        public void DeleteContactByUserId(Guid userId)
        {
            Contact contact = uow.ContactRepository.getContactByUserId(userId);
            uow.ContactRepository.DeleteContact(contact);
            uow.Save();
        }

    }
}
