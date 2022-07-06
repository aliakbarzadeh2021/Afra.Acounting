using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgCostCntrAlloc : BaseEntity
    {
          
 
		public Int32 BdgCostCntAllocId { get; set; }  
 
		public Nullable<Int32> BCnACostCntRef { get; set; }  
 
		public Nullable<Int32> BCnAElmntRef { get; set; }  
 
		public Nullable<Int32> BCnARoleRef { get; set; }  
 
		public Nullable<Int32> BCnAPeriodId { get; set; }  
 
		public Nullable<Double> BCnAPrc { get; set; } 
    }
}


