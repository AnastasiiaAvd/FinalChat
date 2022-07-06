using DomainModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Repositories
{
    public class ChatRepository : ICommonRepository<Chat>
    {
        private readonly ChatDbContext _dbContext;
        public ChatRepository(ChatDbContext db)
        {
            _dbContext = db;
        }
        public IQueryable<Chat> Entities()
        {
            return _dbContext.Set<Chat>();
        }

        public Chat FirstOrDefault(Expression<Func<Chat, bool>> expression)
        {
            return _dbContext.Set<Chat>().FirstOrDefault(expression);
        }

        public void Add(Chat entity)
        {
            _dbContext.Set<Chat>().Add(entity);
        }

        public void Update(Chat entity)
        {
            _dbContext.Set<Chat>().Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(Chat entity)
        {
            _dbContext.Set<Chat>().Remove(entity);
        }

        //public static ICommonRepository<Chat> Instance => new ChatRepository();

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

        public IEnumerable<Chat> GetAll()
        {
            return _dbContext.Set<Chat>();
        }
    }
}