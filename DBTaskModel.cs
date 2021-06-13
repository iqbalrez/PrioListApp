using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PrioList
{
    public partial class DBTaskModel : DbContext
    {
        public DBTaskModel()
            : base("name=DBTaskModel")
        {
        }

        public virtual DbSet<TaskDB> TaskDBs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
