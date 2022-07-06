using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgCostAllocDet : BaseEntity
    {
          
 
		public Int32 BCADHdrRef { get; set; }  
 
		public Int32 BCADCostCntrRef { get; set; }  
 
		public Nullable<Double> BCADAllocQty { get; set; } 
    }
}


