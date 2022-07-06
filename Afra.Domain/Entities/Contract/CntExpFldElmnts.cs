using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntExpFldElmnts : BaseEntity
    {
          
 
		public Int32 CntExpFldElmntId { get; set; }  
 
		public Int32 CEFEFldRef { get; set; }  
 
		public String CEFEValue { get; set; } 
    }
}


