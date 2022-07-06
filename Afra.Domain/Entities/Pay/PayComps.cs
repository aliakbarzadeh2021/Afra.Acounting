using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayComps : BaseEntity
    {
          
 
		public Int32 PayCompID { get; set; }  
 
		public String PayCompName { get; set; }  
 
		public String PayCompType { get; set; } 
    }
}


