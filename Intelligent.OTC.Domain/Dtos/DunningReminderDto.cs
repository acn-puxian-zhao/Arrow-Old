﻿
namespace Intelligent.OTC.Domain.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class DunningReminderDto
    {
        public int Id { get; set; }
        public System.DateTime ActionDate { get; set; }
        public string Deal { get; set; }
        public string TaskId { get; set; }
        public string ReferenceNo { get; set; }
        public string ProcessId { get; set; }
        public string DunStatus { get; set; }
        public string CauseObjectNumber { get; set; }
        public Nullable<int> BatchType { get; set; }
        public string FailedReason { get; set; }
        public Nullable<int> PeriodId { get; set; }
        public int AlertType { get; set; }
        public string CustomerNum { get; set; }
        public string CustomerName { get; set; }
        public string BillGroupCode { get; set; }
        public string BillGroupName { get; set; }
        //public string ExistCont { get; set; }
        public string CusStatus { get; set; }
        public string IsHoldFlg { get; set; }
        public string Operator { get; set; }
        //public IEnumerable<string> ContactList { get; set; }
        public string LegalEntity { get; set; }
        public Nullable<decimal> CreditLimit { get; set; }
        public Nullable<decimal> TotalAmt { get; set; }
        public Nullable<decimal> CurrentAmt { get; set; }
        public Nullable<decimal> FDueOver90Amt { get; set; }
        public Nullable<decimal> PastDueAmt { get; set; }
        public Nullable<decimal> Risk { get; set; }
        public Nullable<decimal> Value { get; set; }
        public string Class { get; set; }
        public string LastRemind { get; set; }

        //public string Contact
        //{
        //    get
        //    {
        //        StringBuilder res = new StringBuilder();
        //        ContactList.ToList().ForEach(c => res.Append(c).Append(","));
        //        return res.ToString().TrimEnd(',');
        //    }
        //}
    }
}
