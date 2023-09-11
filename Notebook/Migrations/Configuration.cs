using Notebook.Classes.DB;
using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;

namespace Notebook.Migrations
{
    internal class Configuration : DbMigrationsConfiguration<DbApp>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }

        protected override void Seed(DbApp context)
        {
            base.Seed(context);
        }
    }
}
