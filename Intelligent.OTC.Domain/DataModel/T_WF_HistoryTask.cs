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
    
    public partial class T_WF_HistoryTask
    {
        public long Id { get; set; }
        public long Id2 { get; set; }
        public string AcceptPeople { get; set; }
        public Nullable<System.DateTime> AcceptTime { get; set; }
        public string CauseObjectNumber { get; set; }
        public Nullable<System.DateTime> FinishTime { get; set; }
        public long SequenceNumber { get; set; }
        public string Status { get; set; }
        public Nullable<long> Activity_Id { get; set; }
        public Nullable<long> ProcessInstance_Id { get; set; }
    
        public virtual T_WF_Activity T_WF_Activity { get; set; }
        public virtual T_WF_ProcessInstance T_WF_ProcessInstance { get; set; }
    }
}
