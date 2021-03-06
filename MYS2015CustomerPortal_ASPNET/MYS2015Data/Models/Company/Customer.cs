//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Web.Script.Serialization;
using Breeze.Sharp;

namespace MYS2015Data.Models.Company
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public Customer()
        {
            this.Activities = new HashSet<Activity>();
            this.Activities1 = new HashSet<Activity>();
            this.Activities_Items = new HashSet<Activities_Items>();
            this.Assets = new HashSet<Asset>();
            this.Assets1 = new HashSet<Asset>();
            this.Assets2 = new HashSet<Asset>();
            this.Customers1 = new HashSet<Customer>();
            this.Documents = new HashSet<Document>();
            this.HistoryNotes = new HashSet<HistoryNote>();
            this.JobRequests = new HashSet<JobRequest>();
            this.JobRequests1 = new HashSet<JobRequest>();
            this.Quotes_Items = new HashSet<Quotes_Items>();
            this.Stocks = new HashSet<Stock>();
        }
    
        public int CustomerID { get; set; }
        public string CustomerRef { get; set; }
        public string CustomerName { get; set; }
        public string BillingPostalName { get; set; }
        public string BillingAddress1 { get; set; }
        public string BillingAddress2 { get; set; }
        public string BillingAddress3 { get; set; }
        public string BillingAddress4 { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingZipCode { get; set; }
        public string BillingCountry { get; set; }
        public string BillingEmail { get; set; }
        public Nullable<double> BillingLatitude { get; set; }
        public Nullable<double> BillingLongitude { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string AltPhone { get; set; }
        public string AltFax { get; set; }
        public string AltEmail { get; set; }
        public string Website { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Twitter { get; set; }
        public string RSS { get; set; }
        public Nullable<decimal> CurrentBalance { get; set; }
        public Nullable<decimal> CreditLimit { get; set; }
        public bool Active { get; set; }
        public string Spare1 { get; set; }
        public string Spare2 { get; set; }
        public string Spare3 { get; set; }
        public string Spare4 { get; set; }
        public string Spare5 { get; set; }
        public string Spare6 { get; set; }
        public string Spare7 { get; set; }
        public string Spare8 { get; set; }
        public string Spare9 { get; set; }
        public string Spare10 { get; set; }
        public string Spare11 { get; set; }
        public string Spare12 { get; set; }
        public Nullable<System.Guid> ERPRef { get; set; }
        public Nullable<int> DefaultContactMethod { get; set; }
        public Nullable<int> RegionID { get; set; }
        public Nullable<bool> OnHold { get; set; }
        public Nullable<int> Groups { get; set; }
        public string LastupdatedBy { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
        public Nullable<System.Guid> ERPBillingAddressRef { get; set; }
        public Nullable<System.Guid> ERPEmailRef { get; set; }
        public Nullable<System.Guid> ERPPhoneRef { get; set; }
        public Nullable<decimal> StandardDiscount { get; set; }
        public string PriceBandTempRef { get; set; }
        public Nullable<long> PriceBandIDRef { get; set; }
        public Nullable<long> SLAId { get; set; }
        public Nullable<bool> IsCustomer { get; set; }
        public Nullable<bool> InActive { get; set; }
        public Nullable<System.Guid> PortalID { get; set; }
        public Nullable<bool> LockedOut { get; set; }
        public Nullable<bool> CanAddAssets { get; set; }
        public Nullable<bool> CanRequestJobs { get; set; }
        public Nullable<bool> IsSite { get; set; }
        public Nullable<int> ParentSiteID { get; set; }
        public Nullable<bool> ViewAssets { get; set; }
        public Nullable<bool> ViewParts { get; set; }
        public Nullable<bool> ViewJobs { get; set; }
        public Nullable<bool> ViewSites { get; set; }
        public Nullable<bool> ViewAssetDocs { get; set; }
        public Nullable<bool> ViewPartDocs { get; set; }
        public Nullable<bool> ViewJobDocs { get; set; }
        public Nullable<bool> ViewAssetHistory { get; set; }
        public Nullable<bool> ViewPartHistory { get; set; }
        public Nullable<bool> ViewJobHistory { get; set; }
        public Nullable<bool> CanEditAssets { get; set; }
        public Nullable<bool> CanAddParts { get; set; }
        public Nullable<bool> CanEditParts { get; set; }
        public Nullable<bool> CanAddSites { get; set; }
        public Nullable<bool> CanEditSites { get; set; }
        public Nullable<bool> DisallowMobile { get; set; }
        public string OnHoldStatus { get; set; }
        public Nullable<long> PaymentTypeID { get; set; }
        public string SalesPerson { get; set; }
        public Nullable<bool> LeadGenerated { get; set; }
        public Nullable<bool> ChargeByDefault { get; set; }
        public Nullable<int> TaxCodeID { get; set; }
        public string JobCompletedHistory { get; set; }
        public string ERPCustomerNumber { get; set; }

        [ScriptIgnore]
        public virtual ICollection<Activity> Activities { get; set; }
        [ScriptIgnore]
        public virtual ICollection<Activity> Activities1 { get; set; }
        [ScriptIgnore]
        public virtual ICollection<Activities_Items> Activities_Items { get; set; }
        [ScriptIgnore]
        public virtual ICollection<Asset> Assets { get; set; }
        [ScriptIgnore]
        public virtual ICollection<Asset> Assets1 { get; set; }
        [ScriptIgnore]
        public virtual ICollection<Asset> Assets2 { get; set; }
        [ScriptIgnore]
        public virtual ICollection<Customer> Customers1 { get; set; }
        [ScriptIgnore]
        public virtual Customer Customer1 { get; set; }
        [ScriptIgnore]
        public virtual TaxCode TaxCode { get; set; }
        [ScriptIgnore]
        public virtual ICollection<Document> Documents { get; set; }
        [ScriptIgnore]
        public virtual ICollection<HistoryNote> HistoryNotes { get; set; }
        [ScriptIgnore]
        public virtual ICollection<JobRequest> JobRequests { get; set; }
        [ScriptIgnore]
        public virtual ICollection<JobRequest> JobRequests1 { get; set; }
        [ScriptIgnore]
        public virtual ICollection<Quotes_Items> Quotes_Items { get; set; }
        [ScriptIgnore]
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
