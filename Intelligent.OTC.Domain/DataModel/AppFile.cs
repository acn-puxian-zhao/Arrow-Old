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
    
    public partial class AppFile
    {
        public int Id { get; set; }
        public string FileId { get; set; }
        public string FileName { get; set; }
        public string Type { get; set; }
        public string PhysicalPath { get; set; }
        public string Operator { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string ContentType { get; set; }
        public string ContentId { get; set; }
    }
}
