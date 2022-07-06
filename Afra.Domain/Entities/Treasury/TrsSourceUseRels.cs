using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsSourceUseRels : BaseEntity
    {
          
 
		public Int32 TSURMaster { get; set; }  
 
		public Int32 TSURChild { get; set; } 
    }
}


