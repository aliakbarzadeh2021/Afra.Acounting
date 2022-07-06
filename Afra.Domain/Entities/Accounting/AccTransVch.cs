using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AccTransVch : BaseEntity
    {
          
 
		public String ATVSrcName { get; set; }  
 
		public Int32 ATVSrcTempNum { get; set; }  
 
		public Int32 ATVTempNum { get; set; }  
 
		public Int32 ATVYear { get; set; } 
    }
}


