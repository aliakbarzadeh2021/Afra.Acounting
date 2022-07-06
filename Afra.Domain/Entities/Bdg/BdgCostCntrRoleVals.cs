using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgCostCntrRoleVals : BaseEntity
    {
          
 
		public Int32 BCnRVRoleRef { get; set; }  
 
		public Int32 BCnRVCostCntRef { get; set; }  
 
		public Int32 BCnRVPeriodId { get; set; }  
 
		public Nullable<Double> BCnRVAmount { get; set; } 
    }
}


