using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SleChngVchTax : BaseEntity
    {
          
 
		public Nullable<Int32> SleChngVchHdrRef { get; set; }  
 
		public Int32 SleChngVchItmRef { get; set; }  
 
		public Int32 SCVTTaxRef { get; set; }  
 
		public Nullable<Double> SCVTTaxAmount { get; set; }  
 
		public Nullable<Double> SCVTAmount { get; set; } 
    }
}


