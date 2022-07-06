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
    public class EditWorkFlowsFormCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 WFFFlowRef { get; set; }  
 
		public Int32 WFFFormRef { get; set; } 

        public void Validate()
        {
            new EditWorkFlowsFormCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
