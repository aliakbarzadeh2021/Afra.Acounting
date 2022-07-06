using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrProcessDetVals : BaseEntity
    {
          
 
		public Int32 GPDVHdrRef { get; set; }  
 
		public Int32 GPDVItmRef { get; set; }  
 
		public String GPDVVal { get; set; } 
    }
}


