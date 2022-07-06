using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CstCostAllocDet : BaseEntity
    {
          
 
		public Int32 CCADHdrRef { get; set; }  
 
		public Int32 CCADCostCntrRef { get; set; }  
 
		public Nullable<Double> CCADAllocQty { get; set; } 
    }
}


