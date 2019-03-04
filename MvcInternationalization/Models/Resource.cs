namespace MvcInternationalization.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Resource
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Culture { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(4000)]
        public string Value { get; set; }
    }
}
