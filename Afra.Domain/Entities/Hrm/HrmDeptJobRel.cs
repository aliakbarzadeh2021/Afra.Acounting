using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmDeptJobRel : BaseEntity
    {
          
 
		public Int32 HDJRDeptRef { get; set; }  
 
		public Int32 HDJRJobRef { get; set; }  
 
		public Nullable<Int32> HDJRCnt { get; set; }  
 
		public String HDJRDescr { get; set; } 
    }
}


