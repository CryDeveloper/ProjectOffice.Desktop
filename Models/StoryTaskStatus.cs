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
    
    public partial class StoryTaskStatus
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int StatusId { get; set; }
        public System.DateTime UpdatedTimeStatus { get; set; }
    
        public virtual Task Task { get; set; }
        public virtual TaskStatus TaskStatus { get; set; }
    }
}
