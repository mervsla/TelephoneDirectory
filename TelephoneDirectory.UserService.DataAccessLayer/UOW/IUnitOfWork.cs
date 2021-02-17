using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.UserService.DataAccessLayer.Repositories.Abstract;

namespace TelephoneDirectory.UserService.DataAccessLayer.UOW
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        IContactRepository ContactRepository { get; }
        void Save();
    }
}
