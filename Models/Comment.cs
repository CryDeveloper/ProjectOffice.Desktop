namespace ProjectOffice.Desktop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comment")]
    public partial class Comment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string SendTime { get; set; }

        public int TaskId { get; set; }

        public int EmploeyyId { get; set; }

        [Required]
        [StringLength(1000)]
        public string Text { get; set; }

        public virtual Emploeyy Emploeyy { get; set; }

        public virtual Task Task { get; set; }
    }
}
