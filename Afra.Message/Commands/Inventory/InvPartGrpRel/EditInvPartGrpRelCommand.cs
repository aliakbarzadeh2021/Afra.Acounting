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
    public class EditInvPartGrpRelCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 IGRGrpRef { get; set; }  
 
		public Int32 IGRPartRef { get; set; }  
 
		public Int32 IGRActive { get; set; } 

        public void Validate()
        {
            new EditInvPartGrpRelCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
