using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmMissions : BaseEntity
    {
          
 
		public Int32 HrmMissionId { get; set; }  
 
		public String HMTitle { get; set; }  
 
		public Nullable<Int32> HMType { get; set; } 
    }
}


