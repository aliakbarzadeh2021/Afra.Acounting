using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmGrpParamStat : BaseEntity
    {
          
 
		public Int32 HrmGrpParamStatId { get; set; }  
 
		public Nullable<Int32> HGPSNum { get; set; }  
 
		public DateTime HGPSIssueDate { get; set; }  
 
		public DateTime HGPSEffectDate { get; set; }  
 
		public String HGPSDescr { get; set; } 
    }
}


