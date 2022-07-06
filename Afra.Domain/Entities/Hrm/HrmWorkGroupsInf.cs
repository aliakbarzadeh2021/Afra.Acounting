using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmWorkGroupsInf : BaseEntity
    {
          
 
		public Int32 HWGIHdrRef { get; set; }  
 
		public String HWGIMonth { get; set; }  
 
		public DateTime HWGIDayDur { get; set; } 
    }
}


