using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrRptGroups : BaseEntity
    {
          
 
		public Int32 RptGroupId { get; set; }  
 
		public String RptGroupTitle { get; set; }  
 
		public String RptSysRef { get; set; }  
 
		public Nullable<Int32> RGParentRef { get; set; } 
    }
}


