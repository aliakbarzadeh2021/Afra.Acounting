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
    public class AddSettingsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public String SettingID { get; set; }  
 
		public String StgValue { get; set; } 

        public void Validate()
        {
            new AddSettingsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
