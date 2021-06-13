using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PrioList
{
    public partial class DBNormalTaskModel : DbContext
    {
        public DBNormalTaskModel()
            : base("name=DBNormalTaskModel")
        {
        }

        public virtual DbSet<NormalTaskDB> NormalTaskDBs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
