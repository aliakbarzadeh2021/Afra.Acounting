using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class GnrUserAlarmsDto
    {
          
 
		public Int32 UserAlarmId { get; set; }  
 
		public Nullable<Int32> UAType { get; set; }  
 
		public Nullable<Int32> UAUserRef { get; set; }  
 
		public Nullable<Int32> UAStartDur { get; set; }  
 
		public Nullable<Int32> UARepeatDur { get; set; } 
    }
}


