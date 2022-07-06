using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CstCostCntrRoleVals : BaseEntity
    {
          
 
		public Int32 CCnRVRoleRef { get; set; }  
 
		public Int32 CCnRVCostCntRef { get; set; }  
 
		public Int32 CCnRVPeriodId { get; set; }  
 
		public Nullable<Double> CCnRVAmount { get; set; } 
    }
}


