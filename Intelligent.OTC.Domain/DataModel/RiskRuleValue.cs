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
    
    public partial class RiskRuleValue
    {
        public int Id { get; set; }
        public string Deal { get; set; }
        public Nullable<int> CalculateType { get; set; }
        public string Begin_Score { get; set; }
        public Nullable<decimal> EndScore { get; set; }
        public Nullable<decimal> RisValue { get; set; }
        public string Description { get; set; }
    }
}
