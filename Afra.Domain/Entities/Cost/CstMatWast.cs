using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CstMatWast : BaseEntity
    {
          
 
		public Int32 CstMatWastId { get; set; }  
 
		public Nullable<Int32> CMWPeriodId { get; set; }  
 
		public DateTime CMWDate { get; set; }  
 
		public Nullable<Int32> CMWCostCntrRef { get; set; }  
 
		public Nullable<Int32> CMWPartRef { get; set; }  
 
		public Nullable<Double> CMWQty { get; set; } 
    }
}


