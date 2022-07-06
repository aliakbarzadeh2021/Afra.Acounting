using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class StkPeriodsDto
    {
          
 
		public Int32 StkPeriodId { get; set; }  
 
		public String SPTitle { get; set; }  
 
		public DateTime SPFromDate { get; set; }  
 
		public DateTime SPToDate { get; set; }  
 
		public Nullable<Int32> SPState { get; set; } 
    }
}


