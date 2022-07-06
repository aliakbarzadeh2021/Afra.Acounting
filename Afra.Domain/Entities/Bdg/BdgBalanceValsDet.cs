using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgBalanceValsDet : BaseEntity
    {
          
 
		public Int32 BBVDParentRef { get; set; }  
 
		public Int32 BBVDMonth { get; set; }  
 
		public Nullable<Double> BBVDVal { get; set; } 
    }
}


