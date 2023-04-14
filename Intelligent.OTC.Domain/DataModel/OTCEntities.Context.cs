﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Intelligent.OTC.Domain.DataModel
{
    using Intelligent.OTC.Common.Utils;
    using System;
    using System.Configuration;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OTCEntities : DbContext
    {
        private static string connectionString = string.Format(ConfigurationManager.ConnectionStrings["OTCEntities"].ConnectionString,
            AESUtil.AESDecrypt(ConfigurationManager.AppSettings["OTC_Password"]));
        public OTCEntities()
            : base(connectionString)
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Contactor> Contactors { get; set; }
        public DbSet<CustomerAging> CustomerAgings { get; set; }
        public DbSet<SysConfig> SysConfigs { get; set; }
        public DbSet<SysType> SysTypes { get; set; }
        public DbSet<SysTypeDetail> SysTypeDetails { get; set; }
        public DbSet<InvoiceAging> InvoiceAging { get; set; }
        public DbSet<Sites> Sites { get; set; }
        public DbSet<CustomerGroupCfg> CustomerGroupCfgs { get; set; }
        public DbSet<MailTemplate> MailTemplates { get; set; }
        public DbSet<FileUploadHistory> FileUploadHistory { get; set; }
        public DbSet<CustomerPaymentBank> CustomerPaymentBank { get; set; }
        public DbSet<FileDownloadHistory> FileDownloadHistory { get; set; }
        public DbSet<PeriodControl> PeriodControls { get; set; }
        public DbSet<RiskRuleValue> RiskRuleValues { get; set; }
        public DbSet<RiskRule> RiskRules { get; set; }
        public DbSet<RiskRuleIndex> RiskRuleIndexs { get; set; }
        public DbSet<CustomerPaymentCircle> CustomerPaymentCircles { get; set; }
        public DbSet<CustomerGroupCfgStaging> CustomerGroupCfgStagings { get; set; }
        public DbSet<CustomerGroupCfgHistory> CustomerGroupCfgHistories { get; set; }
        public DbSet<CustomerLevelView> CustomerLevelView { get; set; }
        public DbSet<CustomerChangeHis> CustomerChangeHis { get; set; }
        public DbSet<CustomerPrioritizationExceptionList> CustomerPrioritizationExceptionLists { get; set; }
        public DbSet<Dispute> Dispute { get; set; }
        public DbSet<ContactHistory> ContactHistory { get; set; }
        public DbSet<Call> Call { get; set; }
        public DbSet<DisputeInvoice> DisputeInvoice { get; set; }
        public DbSet<CollectorAlertPermission> CollectorAlertPermissions { get; set; }
        public DbSet<CollectorTeam> CollectorTeams { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<CustomerContactorView> CustomerContactorView { get; set; }
        public DbSet<CustomerLegalView> CustomerLegalView { get; set; }
        public DbSet<CustomerTeam> CustomerTeams { get; set; }
        public DbSet<CusAgingView> CusAgingView { get; set; }
        public DbSet<CustomerMasterView> CustomerMasterView { get; set; }
        public DbSet<RateTran> RateTran { get; set; }
        public DbSet<CustomerMasterData> CustomerMasterData { get; set; }
        public DbSet<StartSoaAlertView> StartSoaAlertView { get; set; }
        public DbSet<ContactCustomerView> ContactCustomerView { get; set; }
        public DbSet<DisputeHis> DisputeHis { get; set; }
        public DbSet<InvoiceLog> InvoiceLog { get; set; }
        public DbSet<CollectorSignature> CollectorSignatures { get; set; }
        public DbSet<AppFile> AppFiles { get; set; }
        public DbSet<CollectorSoaView> CollectorSoaView { get; set; }
        public DbSet<DunningReminderConfig> DunningReminderConfigs { get; set; }
        public DbSet<CustomerCommon> CustomerCommon { get; set; }
        public DbSet<MailRaw> MailRaws { get; set; }
        public DbSet<DunningReminderView> DunningReminderView { get; set; }
        public DbSet<DisputeTrackingView> DisputeTrackingView { get; set; }
        public DbSet<SpecialNote> SpecialNote { get; set; }
        public DbSet<HoldCustomerView> HoldCutomerView { get; set; }
        public DbSet<Mail> Mail { get; set; }
        public DbSet<CollectorAlert> CollectorAlert { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<HoldCustomer> HoldCustomer { get; set; }
        public DbSet<T_SYS_LOG> T_SYS_LOG { get; set; }
        public DbSet<UnHoldCustomer> UnHoldCustomer { get; set; }
        public DbSet<WorkflowHistory> WorkflowHistory { get; set; }
        public DbSet<MailTmp> MailTmps { get; set; }
        public DbSet<CustomerMail> CustomerMails { get; set; }
        public DbSet<ContactorDomain> ContactorDomains { get; set; }
        public DbSet<CustomerAgingStaging> CustomerAgingStagings { get; set; }
        public DbSet<InvoiceAgingStaging> InvoiceAgingStagings { get; set; }
        public DbSet<T_AssessmentFactor> T_AssessmentFactor { get; set; }
        public DbSet<T_AssessmentStandards> T_AssessmentStandards { get; set; }
        public DbSet<T_AssessmentType> T_AssessmentType { get; set; }
        public DbSet<T_CollectionStrategy> T_CollectionStrategy { get; set; }
        public DbSet<T_CommunicationMethod> T_CommunicationMethod { get; set; }
        public DbSet<T_CustomerAssessment> T_CustomerAssessment { get; set; }
        public DbSet<T_CustomerAssessment_History> T_CustomerAssessment_History { get; set; }
        public DbSet<T_CustomerAssessment_Log> T_CustomerAssessment_Log { get; set; }
        public DbSet<T_CustomerScore> T_CustomerScore { get; set; }
        public DbSet<T_Deal> T_Deal { get; set; }
        public DbSet<T_Collection_Job_Log> T_Collection_Job_Log { get; set; }
        public DbSet<T_Invoice_Detail> T_Invoice_Detail { get; set; }
        public DbSet<T_Invoice_Detail_Staging> T_Invoice_Detail_Staging { get; set; }
        public DbSet<T_MailAccount> T_MailAccount { get; set; }
        public DbSet<T_MailServer> T_MailServer { get; set; }
        public DbSet<T_Customer_AccountPeriod> T_Customer_AccountPeriod { get; set; }
        public DbSet<T_PTPPayment_Invoice> T_PTPPayment_Invoice { get; set; }
        public DbSet<T_INVOICE_VAT> T_INVOICE_VAT { get; set; }
        public DbSet<T_INVOICE_VAT_STAGING> T_INVOICE_VAT_STAGING { get; set; }
        public DbSet<v_AutoSendMailInvoice> v_AutoSendMailInvoice { get; set; }
        public DbSet<V_CustomerAssessment> V_CustomerAssessment { get; set; }
        public DbSet<V_CustomerAssessmentHistory> V_CustomerAssessmentHistory { get; set; }
        public DbSet<V_CollectionReport> V_CollectionReport { get; set; }
        public DbSet<T_LeglalEB> T_LeglalEB { get; set; }
        public DbSet<T_INVOICE_STATUS_STAGING> T_INVOICE_STATUS_STAGING { get; set; }
        public DbSet<T_CUSTOMER_STAGING> T_CUSTOMER_STAGING { get; set; }
        public DbSet<T_PTPPayment> T_PTPPayment { get; set; }
        public DbSet<V_Invoice_PTPDate> V_Invoice_PTPDate { get; set; }
        public DbSet<V_DUN_COUNT> V_DUN_COUNT { get; set; }
        public DbSet<V_DailyAgingReport> V_DailyAgingReport { get; set; }
        public DbSet<T_CUSTOMER_AGING_DAYBACK> T_CUSTOMER_AGING_DAYBACK { get; set; }
        public DbSet<T_TASK> T_TASK { get; set; }
        public DbSet<v_PTPEntry1> v_PTPEntry1 { get; set; }
        public DbSet<v_PTPVATEntry1> v_PTPVATEntry1 { get; set; }
        public DbSet<T_INVOICE_VARDATA> T_INVOICE_VARDATA { get; set; }
        public DbSet<V_Open_AR> V_Open_AR { get; set; }
        public DbSet<V_CashCollected> V_CashCollected { get; set; }
        public DbSet<V_DisputReason> V_DisputReason { get; set; }
        public DbSet<V_STATISTICS_CUSTOMER_CONTACT_COUNT> V_STATISTICS_CUSTOMER_CONTACT_COUNT { get; set; }
        public DbSet<V_STATISTICS_COLLECT> V_STATISTICS_COLLECT { get; set; }
        public DbSet<V_STATISTICS_CUSTOMER_COUNT> V_STATISTICS_CUSTOMER_COUNT { get; set; }
        public DbSet<V_STATISTICS_COLLECTOR> V_STATISTICS_COLLECTOR { get; set; }
        public DbSet<T_COLLECTOR_STATISTICS_HIS> T_COLLECTOR_STATISTICS_HIS { get; set; }
        public DbSet<V_PTPPayment> V_PTPPayment { get; set; }
        public DbSet<T_ALLACCOUNT_TMP> T_ALLACCOUNT_TMP { get; set; }
        public DbSet<T_LSRFSR_CHANGE> T_LSRFSR_CHANGE { get; set; }
        public DbSet<V_CUSTOMER_CONTACTOR_TITLE> V_CUSTOMER_CONTACTOR_TITLE { get; set; }
        public DbSet<T_CONTACTOR_REPLACE> ContactorReplace { get; set; }
    }
}
