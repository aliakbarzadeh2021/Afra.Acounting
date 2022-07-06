using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CstCostCntrAlloc : BaseEntity
    {
          
 
		public Int32 CstCostCntAllocId { get; set; }  
 
		public Nullable<Int32> CCnACostCntRef { get; set; }  
 
		public Nullable<Int32> CCnARoleRef { get; set; }  
 
		public Nullable<Int32> CCnAPeriodId { get; set; }  
 
		public Nullable<Double> CCnAPrc { get; set; } 
    }
}


