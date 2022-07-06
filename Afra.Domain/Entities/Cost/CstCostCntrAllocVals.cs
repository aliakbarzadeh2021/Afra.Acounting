using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CstCostCntrAllocVals : BaseEntity
    {
          
 
		public Int32 CstCostCntrAllocValId { get; set; }  
 
		public Int32 CCAVPutCostId { get; set; }  
 
		public Int32 CCAVRcvCostId { get; set; }  
 
		public String CCAVSLRef { get; set; }  
 
		public Nullable<Double> CCAVValue { get; set; }  
 
		public Int32 CCAVPeriodId { get; set; } 
    }
}


