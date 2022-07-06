using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayVacMonthly : BaseEntity
    {
          
 
		public Int32 PayVacMonthlyId { get; set; }  
 
		public Nullable<Int32> PVMPersRef { get; set; }  
 
		public Nullable<Int32> PVMVacRef { get; set; }  
 
		public Nullable<Int32> PVMIssueYear { get; set; }  
 
		public Nullable<Int32> PVMIssueMonth { get; set; }  
 
		public Nullable<Int32> PVMEffectYear { get; set; }  
 
		public Nullable<Int32> PVMEffectMonth { get; set; }  
 
		public Nullable<Int32> PVMDay { get; set; }  
 
		public Nullable<Int32> PVMHour { get; set; }  
 
		public Nullable<Int32> PVMMinute { get; set; }  
 
		public Nullable<Int32> PVMIYearMonth { get; set; }  
 
		public Nullable<Int32> PVMEYearMonth { get; set; } 
    }
}


