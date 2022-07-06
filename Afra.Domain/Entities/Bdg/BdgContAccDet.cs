using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgContAccDet : BaseEntity
    {
          
 
		public Int32 BCADParentRef { get; set; }  
 
		public Int32 BCADMonth { get; set; }  
 
		public Double BCADAmount { get; set; } 
    }
}


