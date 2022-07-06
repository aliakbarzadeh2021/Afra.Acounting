using Afra.Message.Base;
using Afra.Message.Extentions;
using Afra.Message.Validators;
using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Commands
{
    /// <summary>
    ///  
    /// </summary>
    public class AddGnrUserAlarmsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 UserAlarmId { get; set; }  
 
		public Nullable<Int32> UAType { get; set; }  
 
		public Nullable<Int32> UAUserRef { get; set; }  
 
		public Nullable<Int32> UAStartDur { get; set; }  
 
		public Nullable<Int32> UARepeatDur { get; set; } 

        public void Validate()
        {
            new AddGnrUserAlarmsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
