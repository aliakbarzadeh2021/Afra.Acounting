using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class HrmAimPeriodDto
    {
          
 
		public Int32 HrmAimPeriodId { get; set; }  
 
		public String HAPTitle { get; set; }  
 
		public DateTime HAPDate { get; set; }  
 
		public Nullable<Int32> HAPFormRef { get; set; } 
    }
}


