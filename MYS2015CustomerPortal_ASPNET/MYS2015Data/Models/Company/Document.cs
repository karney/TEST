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
    
    public partial class Document
    {
        public long DocumentID { get; set; }
        public long DataID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<System.Guid> AssetID { get; set; }
        public Nullable<long> PartID { get; set; }
        public Nullable<int> ContactID { get; set; }
        public Nullable<long> ActivityID { get; set; }
        public Nullable<long> ActivityItemID { get; set; }
        public Nullable<long> StockID { get; set; }
        public Nullable<long> InvoiceID { get; set; }
        public Nullable<System.Guid> UserID { get; set; }
        public System.DateTime DateAdded { get; set; }
        public string AddedBy { get; set; }
        public long FileSize { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FileType { get; set; }
        public string DocumentType { get; set; }
        public bool Archived { get; set; }
        public string ArchiveLocation { get; set; }
        public Nullable<bool> VisibleInPortal { get; set; }
        public Nullable<long> SLAID { get; set; }
        public Nullable<long> ContractID { get; set; }
        public Nullable<long> OrderID { get; set; }
        public Nullable<long> PurchaseOrderID { get; set; }
        public Nullable<long> Sales_InvoiceID { get; set; }
        public Nullable<long> Credit_NoteID { get; set; }
        public Nullable<long> Purchase_InvoiceID { get; set; }
    
        public virtual Activity Activity { get; set; }
        public virtual Activities_Items Activities_Items { get; set; }
        public virtual Asset Asset { get; set; }
        public virtual Assets_Parts Assets_Parts { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Documents_Data Documents_Data { get; set; }
        public virtual Stock Stock { get; set; }
    }
}