using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrLimitExcept : BaseEntity
    {
          
 
		public Int32 GnrLimitExceptId { get; set; }  
 
		public Int32 GLEGroupRef { get; set; }  
 
		public Int32 GLEUserRef { get; set; } 
    }
}


