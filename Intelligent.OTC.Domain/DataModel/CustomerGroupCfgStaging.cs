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
    
    public partial class CustomerGroupCfgStaging
    {
        public int Id { get; set; }
        public string Deal { get; set; }
        public string BillGroupCode { get; set; }
        public string BillGroupName { get; set; }
        public Nullable<decimal> OneYearSales { get; set; }
        public string ImportId { get; set; }
        public Nullable<System.DateTime> UploadTime { get; set; }
    }
}
