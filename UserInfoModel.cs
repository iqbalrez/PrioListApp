using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PrioList
{
    public partial class UserInfoModel : DbContext
    {
        public UserInfoModel()
            : base("name=UserInfo")
        {
        }

        public virtual DbSet<UserInfo> UserInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInfo>()
                .Property(e => e.username)
                .IsFixedLength();

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.password)
                .IsFixedLength();
        }
    }
}
