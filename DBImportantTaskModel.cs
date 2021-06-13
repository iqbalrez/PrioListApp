using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PrioList
{
    public partial class DBImportantTaskModel : DbContext
    {
        public DBImportantTaskModel()
            : base("name=DBImportantTaskModel")
        {
        }

        public virtual DbSet<ImportantTaskDB> ImportantTaskDBs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
