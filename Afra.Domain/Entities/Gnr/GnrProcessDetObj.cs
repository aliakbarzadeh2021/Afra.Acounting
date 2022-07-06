using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrProcessDetObj : BaseEntity
    {
          
 
		public Int32 GPDOHdrRef { get; set; }  
 
		public Int32 GPDOItmRef { get; set; }  
 
		public Nullable<Int32> GPDOVal { get; set; }  
 
		public String GPDOCond { get; set; } 
    }
}


