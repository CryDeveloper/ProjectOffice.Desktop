//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectOffice.Desktop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Project
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Project()
        {
            this.Task = new HashSet<Task>();
        }
    
        public int Id { get; set; }
        public string FullTitle { get; set; }
        public string ShortTitle { get; set; }
        public string Icon { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<System.DateTime> DeletedTime { get; set; }
        public Nullable<System.DateTime> StartScheduledDate { get; set; }
        public Nullable<System.DateTime> FinishScheduledDate { get; set; }
        public string Description { get; set; }
        public int CreatorEmployeeId { get; set; }
        public Nullable<int> ResponsibleEmployeeId { get; set; }
    
        public virtual Emploeyy Emploeyy { get; set; }
        public virtual Emploeyy Emploeyy1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Task { get; set; }
    }
}
