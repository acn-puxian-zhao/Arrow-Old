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
    
    public partial class T_WF_Application
    {
        public long Id { get; set; }
        public long activity_id { get; set; }
        public string DllName { get; set; }
        public string TypeName { get; set; }
        public string CallBackUrl { get; set; }
    
        public virtual T_WF_Activity T_WF_Activity { get; set; }
    }
}
