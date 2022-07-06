using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgTopics : BaseEntity
    {
          
 
		public Int32 BdgTopicsId { get; set; }  
 
		public String BTTitle { get; set; }  
 
		public Nullable<Int32> BTPriority { get; set; } 
    }
}


