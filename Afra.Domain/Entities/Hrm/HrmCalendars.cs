using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmCalendars : BaseEntity
    {
          
 
		public Int32 HrmCalendarId { get; set; }  
 
		public String HCTitle { get; set; }  
 
		public Nullable<Int32> HCAccPrdRef { get; set; } 
    }
}


