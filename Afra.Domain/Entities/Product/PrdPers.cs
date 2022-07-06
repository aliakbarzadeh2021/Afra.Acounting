using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PrdPers : BaseEntity
    {
          
 
		public Int32 PrdPersId { get; set; }  
 
		public Int32 PPPersRef { get; set; }  
 
		public Int32 PPAlowProg { get; set; } 
    }
}


