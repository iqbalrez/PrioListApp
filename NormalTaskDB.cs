namespace PrioList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NormalTaskDB")]
    public partial class NormalTaskDB
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Column(Order = 1)]
        [StringLength(50)]
        public string TaskName { get; set; }

        [Column(Order = 2)]
        public DateTime Deadline { get; set; }

        [Column(Order = 3)]
        [StringLength(12)]
        public string PriorityLevel { get; set; }

        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PrioLev { get; set; }

        [Column(Order = 5)]
        public bool IsDone { get; set; }

        [Column(Order = 6)]
        public string userID { get; set; }
    }
}
