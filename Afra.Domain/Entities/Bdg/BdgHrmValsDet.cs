using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgHrmValsDet : BaseEntity
    {
          
 
		public Int32 BHVDParentRef { get; set; }  
 
		public Int32 BHVDMonth { get; set; }  
 
		public Double BHVDAmount { get; set; } 
    }
}


