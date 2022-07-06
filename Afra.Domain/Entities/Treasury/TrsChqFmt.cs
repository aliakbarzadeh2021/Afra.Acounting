using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsChqFmt : BaseEntity
    {
          
 
		public Int32 TrsChqFmtId { get; set; }  
 
		public String TCFTitle { get; set; }  
 
		public String TCFFile { get; set; } 
    }
}


