//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Intelligent.OTC.Domain.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerAging
    {
        public int Id { get; set; }
        public string Deal { get; set; }
        public string ImportId { get; set; }
        public string LegalEntity { get; set; }
        public string CustomerNum { get; set; }
        public string CustomerName { get; set; }
        public string BillGroupCode { get; set; }
        public string BillGroupName { get; set; }
        public string Country { get; set; }
        public string CreditTrem { get; set; }
        public Nullable<decimal> CreditLimit { get; set; }
        public string Collector { get; set; }
        public string CollectorSys { get; set; }
        public Nullable<decimal> TotalAmt { get; set; }
        public Nullable<decimal> CurrentAmt { get; set; }
        public Nullable<decimal> DueoverTotalAmt { get; set; }
        public Nullable<decimal> Due30Amt { get; set; }
        public Nullable<decimal> Due60Amt { get; set; }
        public Nullable<decimal> Due90Amt { get; set; }
        public Nullable<decimal> Due120Amt { get; set; }
        public Nullable<decimal> Due150Amt { get; set; }
        public Nullable<decimal> Due180Amt { get; set; }
        public Nullable<decimal> Due210Amt { get; set; }
        public Nullable<decimal> Due240Amt { get; set; }
        public Nullable<decimal> Due270Amt { get; set; }
        public Nullable<decimal> Due300Amt { get; set; }
        public Nullable<decimal> Due330Amt { get; set; }
        public Nullable<decimal> Due360Amt { get; set; }
        public Nullable<decimal> DueOver360Amt { get; set; }
        public string Sales { get; set; }
        public string RiskScore { get; set; }
        public string CustomerClass { get; set; }
        public string AccountStatus { get; set; }
        public string IsHoldFlg { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string RemoveFlg { get; set; }
        public string Currency { get; set; }
        public string CountryCode { get; set; }
        public Nullable<decimal> OutstandingAmt { get; set; }
        public string CityOrState { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string CustomerCreditMemo { get; set; }
        public string CustomerPayments { get; set; }
        public string CustomerReceiptsAtRisk { get; set; }
        public string CustomerClaims { get; set; }
        public Nullable<decimal> CustomerBalance { get; set; }
        public Nullable<decimal> ArBalancePeriod { get; set; }
        public string SiteUseId { get; set; }
        public Nullable<decimal> DUE15_AMT { get; set; }
        public Nullable<decimal> DUE45_AMT { get; set; }
        public string Ebname { get; set; }
        public Nullable<decimal> TotalFutureDue { get; set; }
        public string Comments { get; set; }
    }
}
