using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PrioList
{
    public partial class TaskListModel : DbContext
    {
        public TaskListModel()
            : base("name=TaskModel")
        {
        }

        public virtual DbSet<TaskList> TaskLists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
