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
    
    public partial class T_WF_RelateData
    {
        public long Id { get; set; }
        public string DataType { get; set; }
        public string Name { get; set; }
        public Nullable<long> ProcessDefine_Id { get; set; }
    
        public virtual T_WF_ProcessDefine T_WF_ProcessDefine { get; set; }
    }
}
