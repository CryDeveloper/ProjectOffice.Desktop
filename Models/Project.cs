namespace ProjectOffice.Desktop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Project")]
    public partial class Project
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Project()
        {
            Task = new HashSet<Task>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FullTitle { get; set; }

        [StringLength(10)]
        public string ShortTitle { get; set; }

        [StringLength(100)]
        public string Icon { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DeletedTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartScheduledDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FinishScheduledDate { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        public int CreatorEmployeeId { get; set; }

        public int? ResponsibleEmployeeId { get; set; }

        public virtual Emploeyy Emploeyy { get; set; }

        public virtual Emploeyy Emploeyy1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Task { get; set; }
    }
}
