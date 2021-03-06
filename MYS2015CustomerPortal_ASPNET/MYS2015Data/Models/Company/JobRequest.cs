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
    
    public partial class JobRequest
    {
        public JobRequest()
        {
            this.Activities_Items = new HashSet<Activities_Items>();
            this.JobRequest_Assets = new HashSet<JobRequest_Assets>();
            this.JobRequest_Parts = new HashSet<JobRequest_Parts>();
        }
    
        public long RequestID { get; set; }
        public int CustomerID { get; set; }
        public int SiteID { get; set; }
        public string Details { get; set; }
        public Nullable<long> ActivityItemID { get; set; }
        public bool JobCreated { get; set; }
        public bool Cancelled { get; set; }
        public bool Approved { get; set; }
        public Nullable<System.DateTime> RequestedJobDate { get; set; }
        public System.DateTime DateRequested { get; set; }
        public string PostalName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public bool Urgent { get; set; }
        public string CompanyComments { get; set; }
        public Nullable<int> ActivityItemTypeID { get; set; }
        public string EmailTo { get; set; }
        public string EmailFrom { get; set; }
        public string EmailBody { get; set; }
        public string PONumber { get; set; }
    
        public virtual ICollection<Activities_Items> Activities_Items { get; set; }
        public virtual Activities_Items Activities_Items1 { get; set; }
        public virtual Activities_Items_Types Activities_Items_Types { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Customer Customer1 { get; set; }
        public virtual ICollection<JobRequest_Assets> JobRequest_Assets { get; set; }
        public virtual ICollection<JobRequest_Parts> JobRequest_Parts { get; set; }
    }
}
