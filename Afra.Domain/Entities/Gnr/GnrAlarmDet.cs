using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrAlarmDet : BaseEntity
    {
          
 
		public Int32 AlarmDetId { get; set; }  
 
		public Int32 ADAlarmTypeRef { get; set; }  
 
		public String ADFieldName { get; set; }  
 
		public String ADFieldTitle { get; set; } 
    }
}


