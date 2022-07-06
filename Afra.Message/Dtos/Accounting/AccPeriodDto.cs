using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class AccPeriodDto
    {
          
 
		public Int32 PeriodId { get; set; }  
 
		public String PeriodTitle { get; set; }  
 
		public DateTime p_FromDate { get; set; }  
 
		public DateTime p_ToDate { get; set; }  
 
		public Int32 p_Year { get; set; } 
    }
}


