//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MYS2015Data.Models.Company
{
    using System;
    using System.Collections.Generic;
    
    public partial class ToDoListItem
    {
        public int ToDoListItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> EstimatedTime { get; set; }
        public Nullable<System.DateTime> ActualTime { get; set; }
        public Nullable<bool> IsComplete { get; set; }
        public string Comments { get; set; }
        public long Activities_Items_ID { get; set; }
        public int Number { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public string UserName { get; set; }
        public Nullable<long> ServiceDateId { get; set; }
        public Nullable<int> TaskTemplateID { get; set; }
        public Nullable<long> Taskwork_TemplateId { get; set; }
        public Nullable<bool> IsServiceDateTaskItem { get; set; }
    
        public virtual Activities_Items Activities_Items { get; set; }
    }
}
