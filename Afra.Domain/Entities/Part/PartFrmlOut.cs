using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PartFrmlOut : BaseEntity
    {
          
 
		public Int32 PFOFrmlRef { get; set; }  
 
		public Int32 PFOPartRef { get; set; }  
 
		public Double PFOQty { get; set; } 
    }
}


