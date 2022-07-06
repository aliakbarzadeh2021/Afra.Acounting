using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntAmntTypes : BaseEntity
    {
          
 
		public Int32 CntAmntTypeId { get; set; }  
 
		public String CATTitle { get; set; }  
 
		public String CATFormula { get; set; } 
    }
}


