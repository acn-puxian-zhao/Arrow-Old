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
    
    public partial class InvoiceLog
    {
        public int Id { get; set; }
        public string Deal { get; set; }
        public string CustomerNum { get; set; }
        public string InvoiceId { get; set; }
        public System.DateTime LogDate { get; set; }
        public string LogPerson { get; set; }
        public string LogAction { get; set; }
        public string LogType { get; set; }
        public string OldStatus { get; set; }
        public string NewStatus { get; set; }
        public string ContactPerson { get; set; }
        public string ProofId { get; set; }
        public string Discription { get; set; }
        public string NewTrack { get; set; }
        public string OldTrack { get; set; }
        public string SiteUseId { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
