namespace PrioList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserDB")]
    public partial class UserDB
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string userID { get; set; }

        [Required]
        [StringLength(30)]
        public string password { get; set; }
    }
}
