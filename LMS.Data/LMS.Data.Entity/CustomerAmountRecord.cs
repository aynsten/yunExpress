//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Data.Entity
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using LighTake.Infrastructure.Seedwork;
    
    public partial class CustomerAmountRecord : Entity
    {
        public virtual string SerialNumber { get; set; }
        public virtual string WayBillNumber { get; set; }
        public virtual string TransactionNo { get; set; }
        public virtual Nullable<int> MoneyChangeTypeID { get; set; }
        public virtual Nullable<int> FeeTypeID { get; set; }
        public virtual Nullable<decimal> Amount { get; set; }
        public virtual Nullable<decimal> Balance { get; set; }
        public virtual System.DateTime CreatedOn { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual string Remark { get; set; }
        public virtual Nullable<System.Guid> CustomerID { get; set; }
        public virtual string CustomerCode { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual FeeType FeeType { get; set; }
        public virtual MoneyChangeTypeInfo MoneyChangeTypeInfo { get; set; }
    }
}