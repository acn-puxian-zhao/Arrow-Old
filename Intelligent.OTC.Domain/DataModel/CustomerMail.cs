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
    
    public partial class CustomerMail
    {
        public int Id { get; set; }
        public string MessageId { get; set; }
        public string CustomerNum { get; set; }
        public string PROCESSED_FLG { get; set; }
        public string SiteUseId { get; set; }
    
        public virtual MailTmp MailTmp { get; set; }
    }
}
