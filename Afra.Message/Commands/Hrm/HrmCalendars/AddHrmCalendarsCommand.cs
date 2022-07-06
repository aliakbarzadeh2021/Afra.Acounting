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
    public class AddHrmCalendarsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmCalendarId { get; set; }  
 
		public String HCTitle { get; set; }  
 
		public Nullable<Int32> HCAccPrdRef { get; set; } 

        public void Validate()
        {
            new AddHrmCalendarsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
