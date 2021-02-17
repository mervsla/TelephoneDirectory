using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.UserService.DataAccessLayer.Repositories.Abstract;
using TelephoneDirectory.UserService.DataAccessLayer.USContext;

namespace TelephoneDirectory.UserService.DataAccessLayer.Repositories.Concrete
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
