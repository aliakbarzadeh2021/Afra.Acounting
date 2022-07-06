using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CstCostCntrFill : BaseEntity
    {
          
 
		public Int32 CCnFCostCenter { get; set; }  
 
		public Int32 CCnFPeriodId { get; set; }  
 
		public Nullable<Double> CCnFHrmTime { get; set; }  
 
		public Nullable<Double> CCnFCstTime { get; set; }  
 
		public Nullable<Double> CCnFPkgHrmTime { get; set; }  
 
		public Nullable<Double> CCnFPkgCstTime { get; set; } 
    }
}


