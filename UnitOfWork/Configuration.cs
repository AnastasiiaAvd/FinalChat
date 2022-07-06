using System.Data.Entity.Migrations;

namespace UnitOfWork
{
    public class Configuration : DbMigrationsConfiguration<ChatDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            // ставим на true, т.к. возможно удаление полей таблицы в которых есть данные, в противном случае не удалит поле
            this.AutomaticMigrationDataLossAllowed = true;
            ContextKey = "DataAccessLayer.ChatDbContext";
        }
    }
}