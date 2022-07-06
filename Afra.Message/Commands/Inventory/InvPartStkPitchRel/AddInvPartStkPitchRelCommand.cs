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
    public class AddInvPartStkPitchRelCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PPRPitchRef { get; set; }  
 
		public Int32 PPRPartRef { get; set; } 

        public void Validate()
        {
            new AddInvPartStkPitchRelCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
