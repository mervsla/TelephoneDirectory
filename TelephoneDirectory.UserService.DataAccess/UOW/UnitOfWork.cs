using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.UserService.DataAccess.Repositories.Abstract;
using TelephoneDirectory.UserService.DataAccess.Repositories.Concrete;
using TelephoneDirectory.UserService.DataAccess.USContext;

namespace TelephoneDirectory.UserService.DataAccess.UOW
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
