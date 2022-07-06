using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CstCostCntrAllocSVals : BaseEntity
    {
          
 
		public Int32 CstCostCntrAllocSValId { get; set; }  
 
		public Int32 CCASVPutCostId { get; set; }  
 
		public Int32 CCASVRcvCostId { get; set; }  
 
		public String CCASVSLRef { get; set; }  
 
		public Nullable<Double> CCASVValue { get; set; }  
 
		public Int32 CCASVPeriodId { get; set; } 
    }
}


