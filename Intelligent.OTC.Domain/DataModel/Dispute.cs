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
    
    public partial class Dispute
    {
        public int Id { get; set; }
        public string Deal { get; set; }
        public string ContactId { get; set; }
        public string Eid { get; set; }
        public string CustomerNum { get; set; }
        public string IssueReason { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.DateTime> CloseDate { get; set; }
        public string Status { get; set; }
        public string CreatePerson { get; set; }
        public string Comments { get; set; }
        public string SiteUseId { get; set; }
        public Nullable<System.DateTime> STATUS_DATE { get; set; }
        public string ActionOwnerDepartmentCode { get; set; }
    }
}
