using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class ShopTaxVals : BaseEntity
    {
          
 
		public Int32 ShopTaxValsId { get; set; }  
 
		public Int32 STVTaxRef { get; set; }  
 
		public DateTime STVDate { get; set; }  
 
		public Nullable<Int32> STVPartRef { get; set; }  
 
		public String STVDescr { get; set; }  
 
		public Nullable<Double> STVAmount { get; set; } 
    }
}


