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
    
    public partial class JobRequest_Assets
    {
        public long RequestAssetID { get; set; }
        public long RequestID { get; set; }
        public System.Guid AssetID { get; set; }
        public string Details { get; set; }
    
        public virtual Asset Asset { get; set; }
        public virtual JobRequest JobRequest { get; set; }
    }
}
