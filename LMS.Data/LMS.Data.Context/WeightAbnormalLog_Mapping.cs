//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Data.Context
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    
    using LMS.Data.Entity;
    
    
    internal partial class WeightAbnormalLog_Mapping : EntityTypeConfiguration<WeightAbnormalLog>
    {
        public WeightAbnormalLog_Mapping()
        {                        
              this.HasKey(t => t.WeightAbnormalLogID);        
              this.ToTable("WeightAbnormalLogs");
              this.Property(t => t.WeightAbnormalLogID).HasColumnName("WeightAbnormalLogID");
              this.Property(t => t.CustomerCode).HasColumnName("CustomerCode").IsRequired().HasMaxLength(20);
              this.Property(t => t.WayBillNumber).HasColumnName("WayBillNumber").IsRequired().HasMaxLength(20);
              this.Property(t => t.CustomerOrderID).HasColumnName("CustomerOrderID");
              this.Property(t => t.TrackingNumber).HasColumnName("TrackingNumber").HasMaxLength(50);
              this.Property(t => t.Length).HasColumnName("Length");
              this.Property(t => t.Width).HasColumnName("Width");
              this.Property(t => t.Height).HasColumnName("Height");
              this.Property(t => t.Weight).HasColumnName("Weight");
              this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
              this.Property(t => t.CreatedBy).HasColumnName("CreatedBy").HasMaxLength(50);
         }
    }
}

