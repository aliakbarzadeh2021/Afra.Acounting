using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SleSrvTax : BaseEntity
    {
          
 
		public Nullable<Int32> SleSrvHdrRef { get; set; }  
 
		public Int32 SleSrvItmRef { get; set; }  
 
		public Int32 SSTTaxRef { get; set; }  
 
		public Nullable<Double> SSTTaxAmount { get; set; }  
 
		public Nullable<Double> SSTAmount { get; set; }  
 
		public Nullable<Double> SSTCurVal { get; set; } 
    }
}


