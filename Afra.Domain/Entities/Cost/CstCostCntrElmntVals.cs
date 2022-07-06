using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CstCostCntrElmntVals : BaseEntity
    {
          
 
		public Int32 CCnEVElmntRef { get; set; }  
 
		public Int32 CCnEVCostCntRef { get; set; }  
 
		public Int32 CCnEVPeriodId { get; set; }  
 
		public Nullable<Double> CCnEVAmount { get; set; } 
    }
}


