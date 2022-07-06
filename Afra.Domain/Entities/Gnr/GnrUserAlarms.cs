using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrUserAlarms : BaseEntity
    {
          
 
		public Int32 UserAlarmId { get; set; }  
 
		public Nullable<Int32> UAType { get; set; }  
 
		public Nullable<Int32> UAUserRef { get; set; }  
 
		public Nullable<Int32> UAStartDur { get; set; }  
 
		public Nullable<Int32> UARepeatDur { get; set; } 
    }
}


