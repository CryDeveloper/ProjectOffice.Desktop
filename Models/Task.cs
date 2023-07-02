namespace ProjectOffice.Desktop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Task")]
    public partial class Task
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Task()
        {
            Attachment = new HashSet<Attachment>();
            Comment = new HashSet<Comment>();
            StoryTaskStatus = new HashSet<StoryTaskStatus>();
            Task1 = new HashSet<Task>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int ProjectId { get; set; }

        [Required]
        [StringLength(100)]
        public string FullTitle { get; set; }

        [StringLength(10)]
        public string ShortTitle { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        public int? ExecutiveEmployeeId { get; set; }

        public int StatusId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UpdatedTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DeletedTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Deadline { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SratActualTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FinishActualTime { get; set; }

        public int? PreviosTaskId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attachment> Attachment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comment { get; set; }

        public virtual Emploeyy Emploeyy { get; set; }

        public virtual Project Project { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoryTaskStatus> StoryTaskStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Task1 { get; set; }

        public virtual Task Task2 { get; set; }

        public virtual TaskStatus TaskStatus { get; set; }

        public virtual Emploeyy Emploeyy1 { get; set; }
    }
}
