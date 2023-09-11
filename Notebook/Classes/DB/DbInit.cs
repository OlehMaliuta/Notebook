using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook.Classes.DB
{
    internal class DbInit : SqliteDropCreateDatabaseAlways<DbApp>
    {
        public DbInit(DbModelBuilder modelBuilder) : base(modelBuilder) { }

        protected override void Seed(DbApp context)
        {
        }
    }
}
