using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class InvStckPeriodRels : BaseEntity
    {
          
 
		public Int32 SRStckPeriodRef { get; set; }  
 
		public Int32 SRStockRef { get; set; }  
 
		public Nullable<Int32> Active { get; set; } 
    }
}


