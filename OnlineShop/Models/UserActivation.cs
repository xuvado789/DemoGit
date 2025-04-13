namespace OnlineShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserActivation")]
    public partial class UserActivation
    {
        [Key]
        [StringLength(300)]
        public string Email { get; set; }

        public Guid Code { get; set; }
    }
}
