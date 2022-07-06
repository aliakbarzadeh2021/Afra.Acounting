using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrAlarmTypes : BaseEntity
    {
          
 
		public Int32 AlarmTypeId { get; set; }  
 
		public String ATDescr { get; set; }  
 
		public String ATSysRef { get; set; }  
 
		public String ATQuery { get; set; } 
    }
}


