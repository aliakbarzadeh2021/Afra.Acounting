using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class InvPartStockRel : BaseEntity
    {
          
 
		public Int32 PSRPartRef { get; set; }  
 
		public Int32 PSRStockRef { get; set; }  
 
		public Nullable<Int32> PSRActive { get; set; } 
    }
}


