using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.UserService.DataAccessLayer.Repositories.Abstract;
using TelephoneDirectory.UserService.DataAccessLayer.Repositories.Concrete;
using TelephoneDirectory.UserService.DataAccessLayer.USContext;

namespace TelephoneDirectory.UserService.DataAccessLayer.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private UserServiceContext usContext;
        public UnitOfWork(UserServiceContext context)
        {
            usContext = context;
            UserRepository = new UserRepository(usContext);
            ContactRepository = new ContactRepository(usContext);
        }

        public IUserRepository UserRepository { get; private set; }

        public IContactRepository ContactRepository { get; private set; }
        public void Save()
        {
            usContext.SaveChanges();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

       
    }
}
