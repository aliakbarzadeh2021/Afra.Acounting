using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmNumbering : BaseEntity
    {
          
 
		public Int32 HrmNumberingId { get; set; }  
 
		public Int32 HNType { get; set; }  
 
		public String HNFormat { get; set; } 
    }
}


