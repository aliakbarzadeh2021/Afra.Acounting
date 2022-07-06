using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmAimPeriod : BaseEntity
    {
          
 
		public Int32 HrmAimPeriodId { get; set; }  
 
		public String HAPTitle { get; set; }  
 
		public DateTime HAPDate { get; set; }  
 
		public Nullable<Int32> HAPFormRef { get; set; } 
    }
}


