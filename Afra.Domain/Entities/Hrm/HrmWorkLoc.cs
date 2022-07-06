using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmWorkLoc : BaseEntity
    {
          
 
		public Int32 HrmWrkLocId { get; set; }  
 
		public String HWLTitle { get; set; } 
    }
}


