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
    
    public partial class DisputeTrackingView
    {
        public int Id { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string Comments { get; set; }
        public string Deal { get; set; }
        public string Collector { get; set; }
        public string BillGroupCode { get; set; }
        public string BillGroupName { get; set; }
        public string Contact { get; set; }
        public string IssueReason { get; set; }
        public string DisputeStatus { get; set; }
        public string CustomerName { get; set; }
        public string DisputeType { get; set; }
        public string Status { get; set; }
        public string States { get; set; }
        public string LegalEntity { get; set; }
        public string CustomerNum { get; set; }
        public string SiteUseid { get; set; }
        public Nullable<decimal> TotalAmt { get; set; }
        public Nullable<decimal> DueoverTotalAmt { get; set; }
        public Nullable<decimal> TotalFutureDue { get; set; }
        public Nullable<decimal> CreditLimit { get; set; }
        public string Sales { get; set; }
        public string CustomerPayments { get; set; }
        public string CreditTerm { get; set; }
        public string TrackStates { get; set; }
        public string ClassLevel { get; set; }
        public string CustomerService { get; set; }
        public Nullable<System.DateTime> STATUS_DATE { get; set; }
        public string Ebname { get; set; }
        public string ActionOwnerDepartmentCode { get; set; }
    }
}
