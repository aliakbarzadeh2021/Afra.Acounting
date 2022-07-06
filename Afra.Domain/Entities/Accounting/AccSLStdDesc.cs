using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AccSLStdDesc : BaseEntity
    {
          
 
		public Int32 stdesc_id { get; set; }  
 
		public String stdesc_Slref { get; set; }  
 
		public String stdesc_str { get; set; } 
    }
}


