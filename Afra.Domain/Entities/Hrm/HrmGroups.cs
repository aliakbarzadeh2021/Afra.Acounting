using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmGroups : BaseEntity
    {
          
 
		public Int32 HrmGrpId { get; set; }  
 
		public String HrmGrpCode { get; set; }  
 
		public String HrmGrpTitle { get; set; } 
    }
}


