using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgHrmBase : BaseEntity
    {
          
 
		public Int32 BdgHrmBaseId { get; set; }  
 
		public Int32 BHBCostCenter { get; set; }  
 
		public Int32 BHBCurPersCnt { get; set; }  
 
		public Int32 BHBBdgPersCnt { get; set; }  
 
		public Int32 BHBPeriodRef { get; set; } 
    }
}


