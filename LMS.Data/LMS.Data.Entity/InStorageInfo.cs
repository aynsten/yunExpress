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
    
    public partial class InStorageInfo : Entity
    {
    
        ICollection<WayBillInfo> _wayBillInfos;
        ICollection<InStorageOrSettlementRelational> _inStorageOrSettlementRelationals;
    
    
        public virtual string InStorageID { get; set; }
        public virtual string ReceivingClerk { get; set; }
        public virtual string CustomerCode { get; set; }
        public virtual Nullable<decimal> TotalWeight { get; set; }
        public virtual Nullable<int> TotalQty { get; set; }
        public virtual Nullable<decimal> MaterialsFee { get; set; }
        public virtual Nullable<decimal> TotalFee { get; set; }
        public virtual Nullable<decimal> Freight { get; set; }
        public virtual Nullable<decimal> Register { get; set; }
        public virtual Nullable<decimal> FuelCharge { get; set; }
        public virtual Nullable<decimal> Surcharge { get; set; }
        public virtual int Status { get; set; }
        public virtual System.DateTime CreatedOn { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual System.DateTime LastUpdatedOn { get; set; }
        public virtual string LastUpdatedBy { get; set; }
        public virtual string Remark { get; set; }
        public virtual Nullable<decimal> TariffPrepayFee { get; set; }
        public virtual decimal PhysicalTotalWeight { get; set; }
        public virtual Nullable<int> PaymentTypeID { get; set; }
    
        public virtual ICollection<WayBillInfo> WayBillInfos 
    	{
            get { return _wayBillInfos  ?? (_wayBillInfos  = new List<WayBillInfo>()); }
            protected set { _wayBillInfos  = value; }
        }
    
        public virtual ICollection<InStorageOrSettlementRelational> InStorageOrSettlementRelationals 
    	{
            get { return _inStorageOrSettlementRelationals  ?? (_inStorageOrSettlementRelationals  = new List<InStorageOrSettlementRelational>()); }
            protected set { _inStorageOrSettlementRelationals  = value; }
        }
    
    }
}
