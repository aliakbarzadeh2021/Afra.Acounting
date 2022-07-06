using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class TrsGuaYearShareDto
    {
          
 
		public Int32 TGYSItmRef { get; set; }  
 
		public Int32 TGYSItmType { get; set; }  
 
		public Int32 TGYSPeriodRef { get; set; }  
 
		public DateTime TGYSToDate { get; set; }  
 
		public Nullable<Double> TGYSVal { get; set; }  
 
		public String TGYSDescr { get; set; } 
    }
}


