using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class SleSrvTaxDto
    {
          
 
		public Nullable<Int32> SleSrvHdrRef { get; set; }  
 
		public Int32 SleSrvItmRef { get; set; }  
 
		public Int32 SSTTaxRef { get; set; }  
 
		public Nullable<Double> SSTTaxAmount { get; set; }  
 
		public Nullable<Double> SSTAmount { get; set; }  
 
		public Nullable<Double> SSTCurVal { get; set; } 
    }
}


