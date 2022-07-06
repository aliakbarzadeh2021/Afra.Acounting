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
    public class EditPrdVchInvDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PVIDHdrRef { get; set; }  
 
		public Int32 PVIDInvHdrId { get; set; } 

        public void Validate()
        {
            new EditPrdVchInvDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
