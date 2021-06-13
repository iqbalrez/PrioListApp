using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PrioList
{
    public partial class DBUserModel : DbContext
    {
        public DBUserModel()
            : base("name=DBUserModel")
        {
        }

        public virtual DbSet<UserDB> UserDBs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
