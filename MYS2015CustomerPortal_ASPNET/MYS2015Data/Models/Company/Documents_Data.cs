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
    
    public partial class Documents_Data
    {
        public Documents_Data()
        {
            this.Documents = new HashSet<Document>();
        }
    
        public long DocumentDataID { get; set; }
        public byte[] Data { get; set; }
    
        public virtual ICollection<Document> Documents { get; set; }
    }
}
