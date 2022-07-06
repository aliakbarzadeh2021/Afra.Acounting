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
    public class EditSMSSettingCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SMSSettingID { get; set; }  
 
		public Int32 SMSCompRef { get; set; }  
 
		public Nullable<Int32> SMSSetUserRef { get; set; }  
 
		public String SMSUserName { get; set; }  
 
		public String SMSUserPass { get; set; }  
 
		public String SMSLineNo { get; set; } 

        public void Validate()
        {
            new EditSMSSettingCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
