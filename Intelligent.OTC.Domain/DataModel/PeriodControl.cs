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
    
    public partial class PeriodControl
    {
        public int Id { get; set; }
        public string Deal { get; set; }
        public System.DateTime PeriodBegin { get; set; }
        public System.DateTime PeriodEnd { get; set; }
        public string SoaFlg { get; set; }
        public string Operator { get; set; }
        public System.DateTime Operatedate { get; set; }
        public string Description { get; set; }
        public System.DateTime EndDate { get; set; }
    }
}
