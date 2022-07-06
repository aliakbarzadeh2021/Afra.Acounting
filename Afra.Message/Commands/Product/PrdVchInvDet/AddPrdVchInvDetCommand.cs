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
    public class AddPrdVchInvDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PVIDHdrRef { get; set; }  
 
		public Int32 PVIDInvHdrId { get; set; } 

        public void Validate()
        {
            new AddPrdVchInvDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
