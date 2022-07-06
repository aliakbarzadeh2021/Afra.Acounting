using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AccVchRels : BaseEntity
    {
          
 
		public Int32 RelAccHdrRef { get; set; }  
 
		public Int32 RelBaseItmRef { get; set; }  
 
		public String RelBaseType { get; set; }  
 
		public Int32 RelAccItmRef { get; set; } 
    }
}


