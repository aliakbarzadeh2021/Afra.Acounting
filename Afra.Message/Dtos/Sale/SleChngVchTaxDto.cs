using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class SleChngVchTaxDto
    {
          
 
		public Nullable<Int32> SleChngVchHdrRef { get; set; }  
 
		public Int32 SleChngVchItmRef { get; set; }  
 
		public Int32 SCVTTaxRef { get; set; }  
 
		public Nullable<Double> SCVTTaxAmount { get; set; }  
 
		public Nullable<Double> SCVTAmount { get; set; } 
    }
}


