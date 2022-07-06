using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SleVchTax : BaseEntity
    {
          
 
		public Nullable<Int32> SleVchHdrRef { get; set; }  
 
		public Int32 SleVchItmRef { get; set; }  
 
		public Int32 SVTTaxRef { get; set; }  
 
		public Nullable<Double> SVTTaxAmount { get; set; }  
 
		public Nullable<Double> SVTAmount { get; set; }  
 
		public Nullable<Double> SVTCurVal { get; set; } 
    }
}


