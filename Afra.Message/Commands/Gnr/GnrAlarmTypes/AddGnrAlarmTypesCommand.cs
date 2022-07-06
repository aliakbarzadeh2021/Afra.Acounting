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
    public class AddGnrAlarmTypesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AlarmTypeId { get; set; }  
 
		public String ATDescr { get; set; }  
 
		public String ATSysRef { get; set; }  
 
		public String ATQuery { get; set; } 

        public void Validate()
        {
            new AddGnrAlarmTypesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
