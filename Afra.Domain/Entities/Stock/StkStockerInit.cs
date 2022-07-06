using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class StkStockerInit : BaseEntity
    {
          
 
		public Int32 SSIPeriodRef { get; set; }  
 
		public Int32 SSIStockerRef { get; set; }  
 
		public Nullable<Double> SSIQty { get; set; }  
 
		public Nullable<Double> SSIDebit { get; set; }  
 
		public Nullable<Double> SSICredit { get; set; } 
    }
}


