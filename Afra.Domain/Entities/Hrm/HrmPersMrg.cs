using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmPersMrg : BaseEntity
    {
          
 
		public Int32 PersMrgId { get; set; }  
 
		public Nullable<Int32> PMgPersRef { get; set; }  
 
		public Nullable<Int32> PersMrgSit { get; set; }  
 
		public DateTime PersMrgDate { get; set; } 
    }
}


