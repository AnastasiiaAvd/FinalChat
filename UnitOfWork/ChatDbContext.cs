using DomainModels;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace UnitOfWork
{
    public class ChatDbContext : DbContext
    {
        public ChatDbContext() : base(ConfigurationManager.AppSettings["EntitiesDataBaseCatalog"])
        {
            // при возникновении ошибки
            // The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer' 
            // registered in the application config file for the ADO.NET provider with invariant name 'System.Data.SqlClient' could not be loaded.
            var _ = typeof(System.Data.Entity.SqlServer.SqlProviderServices);

            // установка инициализации бд - стратегии миграции IDatabaseInitializer
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ChatDbContext, Configuration>());

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Chat> Chats { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>()
                .HasKey(p => p.Id)
                .HasIndex(p => p.ChatId).IsUnique(false);
            modelBuilder.Entity<Message>()
                .HasRequired(p => p.Chat).WithMany(p => p.Messages).HasForeignKey(p => p.ChatId);
            modelBuilder.Entity<Message>().HasIndex(p => p.MessageAuthorId).IsUnique(false);
            modelBuilder.Entity<Message>().HasRequired(p => p.MessageAuthor).WithMany(p => p.Messages).HasForeignKey(p => p.MessageAuthorId).WillCascadeOnDelete(false);

            modelBuilder.Entity<Chat>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Chat>().HasRequired(p => p.ChatOwner).WithMany(p => p.OwnerChats)
                .HasForeignKey(p => p.ChatOwnerId);
            modelBuilder.Entity<Chat>().HasRequired(p => p.ChatGuest).WithMany(p => p.GuestChats).HasForeignKey(p => p.ChatGuestId).WillCascadeOnDelete(false);
            //modelBuilder.Entity<Chat>().HasRequired(s => s.ChatGuest).WithMany().WillCascadeOnDelete(false);
            //modelBuilder.Entity<Message>().HasRequired(s => s.MessageAuthor).WithMany().WillCascadeOnDelete(false);

            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}