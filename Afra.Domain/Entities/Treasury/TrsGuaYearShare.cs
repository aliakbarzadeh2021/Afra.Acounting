using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsGuaYearShare : BaseEntity
    {
          
 
		public Int32 TGYSItmRef { get; set; }  
 
		public Int32 TGYSItmType { get; set; }  
 
		public Int32 TGYSPeriodRef { get; set; }  
 
		public DateTime TGYSToDate { get; set; }  
 
		public Nullable<Double> TGYSVal { get; set; }  
 
		public String TGYSDescr { get; set; } 
    }
}


