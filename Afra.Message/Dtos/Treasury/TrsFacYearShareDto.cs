using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class TrsFacYearShareDto
    {
          
 
		public Int32 TFYSFacRef { get; set; }  
 
		public Int32 TFYSPeriodRef { get; set; }  
 
		public DateTime TFYSToDate { get; set; }  
 
		public Nullable<Double> TFYSVal { get; set; }  
 
		public String TFYSDescr { get; set; } 
    }
}


