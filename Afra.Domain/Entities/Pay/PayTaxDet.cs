using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayTaxDet : BaseEntity
    {
          
 
		public Int32 PayTaxTblDetId { get; set; }  
 
		public Nullable<Int32> PTTDTableRef { get; set; }  
 
		public Int32 PTTDFromVal { get; set; }  
 
		public Int32 PTTDToVal { get; set; }  
 
		public Double PTTDValPrc { get; set; }  
 
		public Nullable<Double> PTTDTax { get; set; } 
    }
}


