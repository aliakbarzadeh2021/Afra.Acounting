using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsFacYearShare : BaseEntity
    {
          
 
		public Int32 TFYSFacRef { get; set; }  
 
		public Int32 TFYSPeriodRef { get; set; }  
 
		public DateTime TFYSToDate { get; set; }  
 
		public Nullable<Double> TFYSVal { get; set; }  
 
		public String TFYSDescr { get; set; } 
    }
}


