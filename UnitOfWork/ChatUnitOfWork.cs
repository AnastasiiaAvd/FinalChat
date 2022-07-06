using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Repositories;

namespace UnitOfWork
{
    public class ChatUnitOfWork : IDisposable
    {
        private ChatDbContext _dbContext = new ChatDbContext();
        private ChatRepository chatRepository;
        private MessageRepository messageRepository;
        private ApplicationUserRepository applicationUserRepository;

        public ChatRepository Chats
        {
            get
            {
                if (chatRepository == null)
                    chatRepository = new ChatRepository(_dbContext);
                return chatRepository;
            }
        }

        public MessageRepository Messages
        {
            get
            {
                if (messageRepository == null)
                    messageRepository = new MessageRepository(_dbContext);
                return messageRepository;
            }
        }

        public ApplicationUserRepository ApplicationUsers
        {
            get
            {
                if (applicationUserRepository == null)
                    applicationUserRepository = new ApplicationUserRepository(_dbContext);
                return applicationUserRepository;
            }
        }

        public void SaveChanges()
        {
            try
            {
                _dbContext.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException e)
            {
                var outputLines = new StringBuilder();
                foreach (var eve in e.EntityValidationErrors)
                {
                    outputLines.AppendLine(
                        $"{DateTime.Now}: Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation errors:");
                    foreach (var ve in eve.ValidationErrors)
                        outputLines.AppendLine($"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
                }

                throw new Exception(outputLines.ToString());
            }
        }

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
