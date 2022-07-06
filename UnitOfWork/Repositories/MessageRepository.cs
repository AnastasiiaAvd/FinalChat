using DomainModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace UnitOfWork.Repositories
{
    public class MessageRepository : ICommonRepository<Message>
    {
        private readonly ChatDbContext _dbContext;
        public MessageRepository(ChatDbContext db)
        {
            _dbContext = db;
        }
        public IQueryable<Message> Entities()
        {
            return _dbContext.Set<Message>();
        }

        public Message FirstOrDefault(Expression<Func<Message, bool>> expression)
        {
            return _dbContext.Set<Message>().FirstOrDefault(expression);
        }

        public void Add(Message entity)
        {
            _dbContext.Set<Message>().Add(entity);
        }

        public void Update(Message entity)
        {
            _dbContext.Set<Message>().Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(Message entity)
        {
            _dbContext.Set<Message>().Remove(entity);
        }

        public IEnumerable<Message> GetAll()
        {
            return _dbContext.Set<Message>();
        }

        //public static ICommonRepository<Message> Instance => new MessageRepository(_dbContext);

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
    }
}