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
    public class EditInvQtPartRelsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InvQtPartRef { get; set; }  
 
		public Int32 InvQtCtrlRef { get; set; } 

        public void Validate()
        {
            new EditInvQtPartRelsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
