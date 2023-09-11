using Notebook.Classes.DB.Models;
using SQLite.CodeFirst;
using System.Data.Entity;

namespace Notebook.Classes.DB
{
    public class DbApp : DbContext
    {
        public DbSet<PersonList> PersonLists { get; set; }
        public DbSet<Person> People { get; set; }

        public DbApp() : base() { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var dbCreator = new SqliteCreateDatabaseIfNotExists<DbApp>(modelBuilder);
            Database.SetInitializer(dbCreator);

            modelBuilder.Entity<Person>()
                .HasRequired(p => p.List)
                .WithMany(pl => pl.People)
                .HasForeignKey(p => p.ListId)
                .WillCascadeOnDelete(true);
        }
    }
}
