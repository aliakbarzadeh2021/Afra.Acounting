using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class StkPeriods : BaseEntity
    {
          
 
		public Int32 StkPeriodId { get; set; }  
 
		public String SPTitle { get; set; }  
 
		public DateTime SPFromDate { get; set; }  
 
		public DateTime SPToDate { get; set; }  
 
		public Nullable<Int32> SPState { get; set; } 
    }
}


