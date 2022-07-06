using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DomainModels;

namespace UnitOfWork.Repositories
{
    public class ApplicationUserRepository : ICommonRepository<ApplicationUser>
    {
        private readonly ChatDbContext _dbContext;
        public ApplicationUserRepository(ChatDbContext db)
        {
            _dbContext = db;
        }
        public IQueryable<ApplicationUser> Entities()
        {
            return _dbContext.Set<ApplicationUser>();
        }

        public ApplicationUser FirstOrDefault(Expression<Func<ApplicationUser, bool>> expression)
        {
            return _dbContext.Set<ApplicationUser>().FirstOrDefault(expression);
        }

        public void Add(ApplicationUser entity)
        {
            _dbContext.Set<ApplicationUser>().Add(entity);
        }

        public void Update(ApplicationUser entity)
        {
            _dbContext.Set<ApplicationUser>().Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(ApplicationUser entity)
        {
            _dbContext.Set<ApplicationUser>().Remove(entity);
        }

        //public static ICommonRepository<ApplicationUser> Instance => new ApplicationUserRepository();

        private bool _disposed;
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IEnumerable<ApplicationUser> GetAll()
        {
            return _dbContext.Set<ApplicationUser>();
        }
    }
}