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
    public class EditGnrFormSettingCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public String GFSFormRef { get; set; }  
 
		public Int32 GFSType { get; set; }  
 
		public String GFSValue { get; set; } 

        public void Validate()
        {
            new EditGnrFormSettingCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
