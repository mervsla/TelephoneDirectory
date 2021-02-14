using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.UserService.DataAccess.Repositories.Abstract;

namespace TelephoneDirectory.UserService.DataAccess.UOW
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        IContactRepository ContactRepository { get; }
        void Save();
    }
}
