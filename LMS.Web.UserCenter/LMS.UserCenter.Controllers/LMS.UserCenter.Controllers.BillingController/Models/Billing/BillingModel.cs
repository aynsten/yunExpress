﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation.Attributes;
using LighTake.Infrastructure.Common;

namespace LMS.UserCenter.Controllers.BillingController.Models
{
    
    public class BillingModel
    {
        public string SerialNumber { get; set; }
        public string CustomerCode { get; set; }
        public string TransactionNo { get; set; }
        public Nullable<int> MoneyChangeTypeID { get; set; }
        public Nullable<int> FeeTypeID { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string Remark { get; set; }
        public string MoneyChangeTypeShortName { get; set; }
    }
}