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
    
    public partial class Stock
    {
        public Stock()
        {
            this.Activities_Items = new HashSet<Activities_Items>();
            this.Activities_Items_Types = new HashSet<Activities_Items_Types>();
            this.Activities_Items_Types1 = new HashSet<Activities_Items_Types>();
            this.Activities_Items_Types2 = new HashSet<Activities_Items_Types>();
            this.Activities_Items_Types3 = new HashSet<Activities_Items_Types>();
            this.Activities_Items_Types4 = new HashSet<Activities_Items_Types>();
            this.Activities_Items_Types5 = new HashSet<Activities_Items_Types>();
            this.Activities_Items_Types6 = new HashSet<Activities_Items_Types>();
            this.Activities_Items_Types7 = new HashSet<Activities_Items_Types>();
            this.Activities_Items_Types8 = new HashSet<Activities_Items_Types>();
            this.Activities_Items_Types9 = new HashSet<Activities_Items_Types>();
            this.Activities_Items_Types10 = new HashSet<Activities_Items_Types>();
            this.Activities_Items_Types11 = new HashSet<Activities_Items_Types>();
            this.Assets = new HashSet<Asset>();
            this.Assets_Parts = new HashSet<Assets_Parts>();
            this.Documents = new HashSet<Document>();
            this.HistoryNotes = new HashSet<HistoryNote>();
            this.Quotes_Items = new HashSet<Quotes_Items>();
        }
    
        public long StockID { get; set; }
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public string StockDescription { get; set; }
        public string ExtRef { get; set; }
        public int StockType { get; set; }
        public string StockCategory { get; set; }
        public string TaxCode { get; set; }
        public string Image { get; set; }
        public string ImageUri { get; set; }
        public Nullable<int> TaxCodesID { get; set; }
        public Nullable<System.Guid> ERPRef { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<bool> BuyingAllowed { get; set; }
        public Nullable<bool> SellingAllowed { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public string leadTime { get; set; }
        public string manufacturerReference { get; set; }
        public string manufacturerCompany { get; set; }
        public string supplierReference { get; set; }
        public string catalogueNumber { get; set; }
        public string packingUnitOfMeasureNumber { get; set; }
        public string sellingUnitOfMeasureNumber { get; set; }
        public string buyingUnitOfMeasureNumber { get; set; }
        public Nullable<decimal> tempQuan { get; set; }
        public Nullable<decimal> tempPrice { get; set; }
        public string tempTaxCode { get; set; }
        public Nullable<bool> InActive { get; set; }
        public string Barcode { get; set; }
        public Nullable<decimal> ItemMargin { get; set; }
        public Nullable<decimal> LabourCost { get; set; }
        public Nullable<decimal> LabourMargin { get; set; }
        public Nullable<decimal> LabourSellingPrice { get; set; }
        public Nullable<bool> DisallowMobile { get; set; }
        public string UnitOfMeasureString { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
        public string AddedBy { get; set; }
        public Nullable<decimal> ReorderQuantity { get; set; }
        public Nullable<decimal> SupplierLeadTimeDays { get; set; }
        public Nullable<long> NominalCodeID { get; set; }
        public Nullable<long> PurchaseNominalCodeID { get; set; }
        public Nullable<int> DefaultSupplierID { get; set; }
        public string AlternateStock1 { get; set; }
        public string AlternateStock2 { get; set; }
        public string AlternateStock3 { get; set; }
        public Nullable<decimal> OverallMinimumLevel { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
        public Nullable<int> PurchaseTaxCodeID { get; set; }
        public Nullable<bool> IsCustomerOnly { get; set; }
        public string ERPStockNumber { get; set; }
    
        public virtual ICollection<Activities_Items> Activities_Items { get; set; }
        public virtual ICollection<Activities_Items_Types> Activities_Items_Types { get; set; }
        public virtual ICollection<Activities_Items_Types> Activities_Items_Types1 { get; set; }
        public virtual ICollection<Activities_Items_Types> Activities_Items_Types2 { get; set; }
        public virtual ICollection<Activities_Items_Types> Activities_Items_Types3 { get; set; }
        public virtual ICollection<Activities_Items_Types> Activities_Items_Types4 { get; set; }
        public virtual ICollection<Activities_Items_Types> Activities_Items_Types5 { get; set; }
        public virtual ICollection<Activities_Items_Types> Activities_Items_Types6 { get; set; }
        public virtual ICollection<Activities_Items_Types> Activities_Items_Types7 { get; set; }
        public virtual ICollection<Activities_Items_Types> Activities_Items_Types8 { get; set; }
        public virtual ICollection<Activities_Items_Types> Activities_Items_Types9 { get; set; }
        public virtual ICollection<Activities_Items_Types> Activities_Items_Types10 { get; set; }
        public virtual ICollection<Activities_Items_Types> Activities_Items_Types11 { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
        public virtual ICollection<Assets_Parts> Assets_Parts { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<HistoryNote> HistoryNotes { get; set; }
        public virtual ICollection<Quotes_Items> Quotes_Items { get; set; }
        public virtual TaxCode TaxCode1 { get; set; }
        public virtual TaxCode TaxCode2 { get; set; }
    }
}