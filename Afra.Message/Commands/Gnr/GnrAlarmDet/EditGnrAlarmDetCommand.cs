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
    public class EditGnrAlarmDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AlarmDetId { get; set; }  
 
		public Int32 ADAlarmTypeRef { get; set; }  
 
		public String ADFieldName { get; set; }  
 
		public String ADFieldTitle { get; set; } 

        public void Validate()
        {
            new EditGnrAlarmDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
