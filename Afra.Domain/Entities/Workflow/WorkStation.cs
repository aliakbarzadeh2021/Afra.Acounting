using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class WorkStation : BaseEntity
    {
          
 
		public Int32 WorkStationId { get; set; }  
 
		public Nullable<Int32> WCostCenterRef { get; set; }  
 
		public String WTitle { get; set; } 
    }
}


