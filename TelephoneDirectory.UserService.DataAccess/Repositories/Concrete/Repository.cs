using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.UserService.DataAccess.Repositories.Abstract;
using TelephoneDirectory.UserService.DataAccess.USContext;

namespace TelephoneDirectory.UserService.DataAccess.Repositories.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {

        protected UserServiceContext _context;
        private DbSet<T> _dbSet;
        public Repository(UserServiceContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }


    }
}
