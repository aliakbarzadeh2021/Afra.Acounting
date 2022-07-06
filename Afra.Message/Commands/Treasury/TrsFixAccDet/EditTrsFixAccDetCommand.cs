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
    public class EditTrsFixAccDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public String TFADType { get; set; }  
 
		public Int32 TFADRole { get; set; }  
 
		public String TFADSLRef { get; set; } 

        public void Validate()
        {
            new EditTrsFixAccDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
