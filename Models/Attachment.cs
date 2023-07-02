namespace ProjectOffice.Desktop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Attachment")]
    public partial class Attachment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int TaskId { get; set; }

        [Required]
        [StringLength(100)]
        public string Atttachment { get; set; }

        public virtual Task Task { get; set; }
    }
}
