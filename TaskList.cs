namespace PrioList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaskList")]
    public partial class TaskList
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string TaskName { get; set; }

        public DateTime Deadline { get; set; }

        [Required]
        [StringLength(12)]
        public string PriorityLevel { get; set; }

        public int PrioLev { get; set; }
    }
}
