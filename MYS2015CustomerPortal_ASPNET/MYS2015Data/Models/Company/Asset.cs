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
    
    public partial class Asset
    {
        public Asset()
        {
            this.Activities_Items = new HashSet<Activities_Items>();
            this.Activities_Items_Assets = new HashSet<Activities_Items_Assets>();
            this.Assets_History = new HashSet<Assets_History>();
            this.Assets_Parts = new HashSet<Assets_Parts>();
            this.Assets_ServiceHistory = new HashSet<Assets_ServiceHistory>();
            this.Documents = new HashSet<Document>();
            this.HistoryNotes = new HashSet<HistoryNote>();
            this.JobRequest_Assets = new HashSet<JobRequest_Assets>();
        }
    
        public System.Guid AssetID { get; set; }
        public Nullable<int> OriginatorCref { get; set; }
        public Nullable<int> BelongsToCref { get; set; }
        public Nullable<int> CurrentClientCref { get; set; }
        public string PostalName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
        public Nullable<double> Longitude { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<long> WarehouseID { get; set; }
        public Nullable<long> StockItemID { get; set; }
        public Nullable<long> imageID { get; set; }
        public string imageName { get; set; }
        public Nullable<long> image2ID { get; set; }
        public string imageName2 { get; set; }
        public Nullable<long> image3ID { get; set; }
        public string imageName3 { get; set; }
        public Nullable<long> image4ID { get; set; }
        public string imageName4 { get; set; }
        public Nullable<long> image5ID { get; set; }
        public string imageName5 { get; set; }
        public Nullable<long> image6ID { get; set; }
        public string imageName6 { get; set; }
        public string ModelName { get; set; }
        public string ModelData { get; set; }
        public string URI { get; set; }
        public string IP { get; set; }
        public string Port { get; set; }
        public string Barcode1 { get; set; }
        public string Barcode2 { get; set; }
        public string Barcode3 { get; set; }
        public string Barcode4 { get; set; }
        public string Barcode5 { get; set; }
        public string RFID1 { get; set; }
        public string RFID2 { get; set; }
        public string RFID3 { get; set; }
        public string RFID4 { get; set; }
        public string RFID5 { get; set; }
        public string SerialNumber { get; set; }
        public string SiteLocale { get; set; }
        public Nullable<int> AssetTypeID { get; set; }
        public Nullable<int> AssetSubTypeID { get; set; }
        public Nullable<int> CustomerRating { get; set; }
        public Nullable<double> Height { get; set; }
        public Nullable<double> Width { get; set; }
        public Nullable<double> Depth { get; set; }
        public Nullable<int> WeightMeasure { get; set; }
        public Nullable<int> DimensionMeasure { get; set; }
        public Nullable<System.DateTime> Warranty1Start { get; set; }
        public Nullable<System.DateTime> Warranty1End { get; set; }
        public Nullable<System.DateTime> Warranty2Start { get; set; }
        public Nullable<System.DateTime> Warranty2End { get; set; }
        public string Details { get; set; }
        public string LastupdatedBy { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> SpareDT1 { get; set; }
        public Nullable<System.DateTime> SpareDT2 { get; set; }
        public Nullable<System.DateTime> SpareDT3 { get; set; }
        public Nullable<System.DateTime> SpareDT4 { get; set; }
        public string SpareText1 { get; set; }
        public string SpareText2 { get; set; }
        public string SpareText3 { get; set; }
        public string SpareText4 { get; set; }
        public Nullable<int> SpareInt1 { get; set; }
        public Nullable<int> SpareInt2 { get; set; }
        public Nullable<int> SpareInt3 { get; set; }
        public Nullable<int> SpareInt4 { get; set; }
        public Nullable<bool> SpareBool1 { get; set; }
        public Nullable<bool> SpareBool2 { get; set; }
        public Nullable<bool> SpareBool3 { get; set; }
        public Nullable<bool> SpareBool4 { get; set; }
        public Nullable<int> GeoFence { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> OnRepair { get; set; }
        public Nullable<bool> OnSite { get; set; }
        public Nullable<double> Temperature { get; set; }
        public Nullable<double> Pressure { get; set; }
        public Nullable<double> ExtHeight { get; set; }
        public Nullable<double> ExtWidth { get; set; }
        public Nullable<double> ExtDepth { get; set; }
        public Nullable<double> Weight { get; set; }
        public Nullable<double> ExtWeight { get; set; }
        public Nullable<int> TemperatureMeasure { get; set; }
        public Nullable<int> PressureMeasure { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
        public Nullable<double> CostPrice { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public Nullable<double> CurrentPrice { get; set; }
        public Nullable<bool> CalculateDep { get; set; }
        public Nullable<double> DepPercentage { get; set; }
        public Nullable<int> PeriodDep { get; set; }
        public Nullable<long> SLAId { get; set; }
        public Nullable<bool> InActive { get; set; }
        public Nullable<bool> DisallowMobile { get; set; }
        public Nullable<bool> OnHire { get; set; }
        public string SpareText5 { get; set; }
        public string SpareText6 { get; set; }
        public string SpareText7 { get; set; }
        public string SpareText8 { get; set; }
        public string SpareText9 { get; set; }
        public string SpareText10 { get; set; }
        public string SpareText1b { get; set; }
        public string SpareText2b { get; set; }
        public string SpareText3b { get; set; }
        public string SpareText4b { get; set; }
        public string SpareText5b { get; set; }
        public string SpareText6b { get; set; }
        public string SpareText7b { get; set; }
        public string SpareText8b { get; set; }
        public string SpareText9b { get; set; }
        public string SpareText10b { get; set; }
        public string TempJID { get; set; }
        public string TempJDts { get; set; }
        public Nullable<int> VisitsPerYear { get; set; }
        public Nullable<bool> IsVehicle { get; set; }
        public Nullable<bool> IsEquipment { get; set; }
    
        public virtual ICollection<Activities_Items> Activities_Items { get; set; }
        public virtual ICollection<Activities_Items_Assets> Activities_Items_Assets { get; set; }
        public virtual Stock Stock { get; set; }
        public virtual Assets_SubTypes Assets_SubTypes { get; set; }
        public virtual Assets_Types Assets_Types { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Customer Customer1 { get; set; }
        public virtual Customer Customer2 { get; set; }
        public virtual ICollection<Assets_History> Assets_History { get; set; }
        public virtual ICollection<Assets_Parts> Assets_Parts { get; set; }
        public virtual ICollection<Assets_ServiceHistory> Assets_ServiceHistory { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<HistoryNote> HistoryNotes { get; set; }
        public virtual ICollection<JobRequest_Assets> JobRequest_Assets { get; set; }
    }
}
