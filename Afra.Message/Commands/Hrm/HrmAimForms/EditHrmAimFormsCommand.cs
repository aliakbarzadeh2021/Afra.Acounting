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
    public class EditHrmAimFormsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmAimFormId { get; set; }  
 
		public String HAFTitle { get; set; } 

        public void Validate()
        {
            new EditHrmAimFormsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
