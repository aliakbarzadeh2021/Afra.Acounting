using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class StkStockerInitDto
    {
          
 
		public Int32 SSIPeriodRef { get; set; }  
 
		public Int32 SSIStockerRef { get; set; }  
 
		public Nullable<Double> SSIQty { get; set; }  
 
		public Nullable<Double> SSIDebit { get; set; }  
 
		public Nullable<Double> SSICredit { get; set; } 
    }
}


