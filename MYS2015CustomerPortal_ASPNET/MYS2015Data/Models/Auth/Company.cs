//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MYS2015Data.Models.Auth
{
    using System;
    using System.Collections.Generic;
    
    public partial class Company
    {
        public long ProfileCompanyID { get; set; }
        public string CompanyName { get; set; }
        public string Industry { get; set; }
        public Nullable<int> NumEmployees { get; set; }
        public string HearAbout { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string Email { get; set; }
        public string WorkPhone { get; set; }
        public string Website { get; set; }
        public byte[] Logo { get; set; }
        public string Fax { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
        public string ContactFirstname { get; set; }
        public string ContactSurname { get; set; }
        public string CompanyServer { get; set; }
        public string CompanyCatalog { get; set; }
        public int SubscriptionStatus { get; set; }
        public System.DateTime TrialEndDate { get; set; }
        public string CardPrefix { get; set; }
        public string CardFirstname { get; set; }
        public string CardSurname { get; set; }
        public string SubscriberEmail { get; set; }
        public string SubscriberPhone { get; set; }
        public Nullable<int> CardType { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public Nullable<int> ExpiryDateMonth { get; set; }
        public Nullable<int> ExpiryDateYear { get; set; }
        public Nullable<int> StartDateMonth { get; set; }
        public Nullable<int> StartDateYear { get; set; }
        public string CardAddress1 { get; set; }
        public string CardAddress2 { get; set; }
        public string CardAddress3 { get; set; }
        public string CardAddress4 { get; set; }
        public string CardCity { get; set; }
        public string CardZipCode { get; set; }
        public string CardState { get; set; }
        public string CardCountry { get; set; }
        public Nullable<System.DateTime> CreationDate1 { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public string SDataUrl { get; set; }
        public string SDataUN { get; set; }
        public string SDataPW { get; set; }
        public string QuickBooksUrl { get; set; }
        public string QuickBooksUN { get; set; }
        public string QuickBooksPW { get; set; }
        public string JobSheetEmailHTML { get; set; }
        public string VATNo { get; set; }
        public Nullable<bool> UsesSage { get; set; }
        public Nullable<bool> UsesReports { get; set; }
        public string CurrencyCharacter { get; set; }
        public Nullable<bool> IsFreemium { get; set; }
        public Nullable<bool> CustomerPortalEnabled { get; set; }
        public Nullable<bool> ViewAssets { get; set; }
        public Nullable<bool> ViewParts { get; set; }
        public Nullable<bool> ViewJobs { get; set; }
        public Nullable<bool> ViewRequests { get; set; }
        public Nullable<bool> ViewSites { get; set; }
        public Nullable<bool> CanAddAssets { get; set; }
        public Nullable<bool> CanEditAssets { get; set; }
        public Nullable<bool> CanAddParts { get; set; }
        public Nullable<bool> CanEditParts { get; set; }
        public Nullable<bool> ViewAssetDocs { get; set; }
        public Nullable<bool> ViewPartDocs { get; set; }
        public Nullable<bool> ViewJobDocs { get; set; }
        public Nullable<bool> ViewAssetHistory { get; set; }
        public Nullable<bool> ViewPartHistory { get; set; }
        public Nullable<bool> ViewJobHistory { get; set; }
        public Nullable<bool> CanEditSites { get; set; }
        public Nullable<bool> CanAddSites { get; set; }
        public Nullable<bool> ViewSiteDocs { get; set; }
        public Nullable<bool> ViewSiteHistory { get; set; }
        public string JobRequestEmail { get; set; }
        public Nullable<bool> ShowOwnLogo { get; set; }
        public Nullable<bool> NotifyCustomerOnJobCompletion { get; set; }
        public Nullable<bool> NotifyCustomerOnJobAssignment { get; set; }
        public Nullable<bool> NotifyCustomerOnJobCreation { get; set; }
        public Nullable<bool> NotifyEngineerByEmailOfJobAssignment { get; set; }
        public string CustomerEmailJobTemplate { get; set; }
        public string CustomerEmailJobSubject { get; set; }
        public string CustomerEmailQuoteTemplate { get; set; }
        public string CustomerEmailQuoteSubject { get; set; }
        public string EmailCompleteJobsInternallyTo { get; set; }
        public string CustomerEmailPortalSettingsTemplate { get; set; }
        public string CustomerEmailPortalSettingsSubject { get; set; }
        public Nullable<long> NotificationID { get; set; }
        public Nullable<long> CompanyTargetID { get; set; }
        public Nullable<bool> dbEnabled { get; set; }
        public Nullable<int> dbType { get; set; }
        public string dbUN { get; set; }
        public string dbPW { get; set; }
        public string dbToken { get; set; }
        public string dbCustFolder { get; set; }
        public string dbSiteFolder { get; set; }
        public string dbSuppFolder { get; set; }
        public string dbJobsFolder { get; set; }
        public string dbQuotesFolder { get; set; }
        public string dbAssetsFolder { get; set; }
        public string dbAssetPartsFolder { get; set; }
        public string dbOrdersFolder { get; set; }
        public string dbInvoicesFolder { get; set; }
        public string dbContractsFolder { get; set; }
        public string dbPurchaseOrdersFolder { get; set; }
        public Nullable<bool> APIEnabled { get; set; }
        public string LocalDiallingCode { get; set; }
        public string dbProjectsFolder { get; set; }
        public Nullable<bool> NotifyJobCustomerOnHold { get; set; }
        public Nullable<bool> NotifyJobsInCloseProximity { get; set; }
        public Nullable<bool> NotifyOnJobOverlap { get; set; }
        public Nullable<bool> Cal_ShowWH { get; set; }
        public Nullable<bool> Cal_ShowCostings { get; set; }
        public Nullable<bool> Cal_ShowTimeUtil { get; set; }
        public Nullable<bool> RequireStockToAssignJob { get; set; }
        public Nullable<bool> Job_ReqCustSig { get; set; }
        public Nullable<bool> Job_ReqUserSig { get; set; }
        public Nullable<bool> Order_ConsolQuantities { get; set; }
        public Nullable<bool> Order_ChargeParts { get; set; }
        public Nullable<bool> Order_ChargeLabour { get; set; }
        public Nullable<bool> Order_ChargeExpenses { get; set; }
        public Nullable<bool> Order_ShowContractDesc { get; set; }
        public Nullable<bool> Order_CheckForContracts { get; set; }
        public Nullable<bool> Order_IncJobID { get; set; }
        public Nullable<bool> Order_IncWorkDone { get; set; }
        public Nullable<bool> Order_IncFurtherWork { get; set; }
        public Nullable<bool> Order_IncJobUser { get; set; }
        public Nullable<bool> Order_IncJobAddress { get; set; }
        public Nullable<bool> Order_IncJobAssetDetails { get; set; }
        public Nullable<bool> Order_IncJobDate { get; set; }
        public Nullable<bool> Order_ConsolTotalPriceForJob { get; set; }
        public Nullable<bool> Order_ConsolTotalPriceSeperatePartsLabour { get; set; }
        public Nullable<long> Order_TextItemNominalCode { get; set; }
        public Nullable<bool> Job_CopyFaultDetails { get; set; }
        public Nullable<bool> Order_IncWorkToBeDone { get; set; }
        public Nullable<bool> Stock_ReduceOnJob { get; set; }
        public Nullable<bool> Stock_ReduceOnOrder { get; set; }
        public Nullable<long> Order_CarriageNominalCode { get; set; }
        public Nullable<bool> Job_CopyJobTypeDetails { get; set; }
        public Nullable<bool> SyncSageStock { get; set; }
        public Nullable<bool> SyncSageStockOnce { get; set; }
        public int SyncSageStockCount { get; set; }
        public int SyncSageStockMaxItems { get; set; }
        public int SyncSageStockPageSize { get; set; }
        public int SyncSagePricesCount { get; set; }
        public int SyncSagePricesMaxItems { get; set; }
        public int SyncSagePricesPageSize { get; set; }
        public Nullable<bool> SyncSageCustomers { get; set; }
        public int SyncSageCustomersCount { get; set; }
        public int SyncSageCustomersMaxItems { get; set; }
        public int SyncSageCustomersPageSize { get; set; }
        public int SyncSageDeliveryAddressesCount { get; set; }
        public int SyncSageDeliveryAddressesMaxItems { get; set; }
        public int SyncSageDeliveryAddressesPageSize { get; set; }
        public Nullable<bool> SyncSageContacts { get; set; }
        public int SyncSageContactsCount { get; set; }
        public int SyncSageContactsMaxItems { get; set; }
        public int SyncSageContactsPageSize { get; set; }
        public Nullable<bool> SyncSageSuppliers { get; set; }
        public Nullable<bool> SyncPostSite { get; set; }
        public Nullable<bool> SyncSage { get; set; }
        public Nullable<bool> SyncSageDeliveryAddresses { get; set; }
        public Nullable<bool> SyncSageContactsEmails { get; set; }
        public Nullable<bool> SyncSageContactsTels { get; set; }
        public Nullable<bool> SyncSageContactsAddresses { get; set; }
        public Nullable<bool> SyncSageCustomersEmails { get; set; }
        public Nullable<bool> SyncSageCustomersTels { get; set; }
        public Nullable<bool> SyncOrdersAlwaysSync { get; set; }
        public Nullable<bool> SyncPOrdersAlwaysSync { get; set; }
        public Nullable<bool> UseTextMarketing { get; set; }
        public string tmUsername { get; set; }
        public string tmPassword { get; set; }
        public Nullable<System.Guid> ResellerID { get; set; }
        public Nullable<bool> Invoice_Borderless { get; set; }
        public Nullable<bool> AllowZeroStockOnDevice { get; set; }
        public Nullable<bool> AllowSearchAllCustomerSites { get; set; }
        public Nullable<bool> AutoRefreshJobList { get; set; }
        public string CustomersDropdown { get; set; }
        public Nullable<int> TypeOfRates { get; set; }
        public string itemUnspecified { get; set; }
        public string accountAPName { get; set; }
        public string accountARName { get; set; }
        public string accountExpenseName { get; set; }
        public string accountIncomeName { get; set; }
        public Nullable<bool> QBOSync { get; set; }
        public Nullable<bool> QBOPayments { get; set; }
        public Nullable<int> QBOPaymentsNo { get; set; }
        public Nullable<bool> QBOCustomers { get; set; }
        public Nullable<int> QBOCustomersNo { get; set; }
        public Nullable<bool> QBOSites { get; set; }
        public Nullable<int> QBOSitesNo { get; set; }
        public Nullable<bool> QBOSuppliers { get; set; }
        public Nullable<int> QBOSuppliersNo { get; set; }
        public Nullable<bool> QBOTaxCodes { get; set; }
        public Nullable<int> QBOTaxCodesNo { get; set; }
        public Nullable<bool> QBOOrders { get; set; }
        public Nullable<int> QBOOrdersNo { get; set; }
        public Nullable<bool> QBOPurchaseOrders { get; set; }
        public Nullable<int> QBOPurchaseOrdersNo { get; set; }
        public Nullable<bool> QBOPaymentTypes { get; set; }
        public Nullable<int> QBOPaymentTypesNo { get; set; }
        public Nullable<bool> QBOStock { get; set; }
        public Nullable<int> QBOStockNo { get; set; }
        public Nullable<bool> AllowSearchAllSiteCustomers { get; set; }
        public Nullable<bool> SearchSitesInCustomersList { get; set; }
        public Nullable<bool> SearchCustomersInSitesList { get; set; }
        public Nullable<bool> AlwaysShowCurrentPosition { get; set; }
        public Nullable<bool> IsShowLastPosition { get; set; }
        public Nullable<int> SetDefaultPosition { get; set; }
        public string PrefixJobId { get; set; }
        public string SuffixJobId { get; set; }
        public string DefaultAddress1 { get; set; }
        public string DefaultAddress2 { get; set; }
        public string DefaultAddress3 { get; set; }
        public string DefaultAddress4 { get; set; }
        public string DefaultCity { get; set; }
        public string DefaultState { get; set; }
        public string DefaultCountry { get; set; }
        public string DefaultZipCode { get; set; }
        public Nullable<int> DefaultFilterJobsAssets { get; set; }
        public Nullable<bool> UsesQuickbooks { get; set; }
        public Nullable<bool> UsesSage300 { get; set; }
        public Nullable<bool> SyncSage300 { get; set; }
        public Nullable<bool> UsesSap { get; set; }
        public Nullable<bool> SyncSap { get; set; }
        public string dbSalesInvoicesFolder { get; set; }
        public string dbCreditNotesFolder { get; set; }
        public string dbPurchaseInvoicesFolder { get; set; }
        public Nullable<long> DocStorageCapacity { get; set; }
        public Nullable<long> TotalUsedStorage { get; set; }
        public Nullable<int> JobCostsCalculationType { get; set; }
        public Nullable<bool> UseCostsFromPO { get; set; }
        public Nullable<int> UsedJobRevenueType { get; set; }
        public Nullable<int> JobOrder { get; set; }
        public Nullable<bool> EnableFPriceForCustomer { get; set; }
        public string ServiceLinkCompany { get; set; }
        public Nullable<bool> Job_UseSiteMailPhone { get; set; }
        public Nullable<bool> Job_UseCustomerMailPhone { get; set; }
        public Nullable<bool> IsPaidForGPS { get; set; }
        public Nullable<bool> MergeProjOnCompletion { get; set; }
        public Nullable<bool> MergeProjCharges { get; set; }
        public Nullable<bool> MergeProjParts { get; set; }
        public Nullable<bool> MergeProjComments { get; set; }
        public Nullable<bool> MergeProjForms { get; set; }
        public Nullable<bool> AutoConvertSDToJob { get; set; }
        public Nullable<int> DaysToCleanGPSData { get; set; }
    }
}
