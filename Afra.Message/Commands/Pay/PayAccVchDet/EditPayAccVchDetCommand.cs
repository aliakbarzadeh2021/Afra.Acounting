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
    public class EditPayAccVchDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayAccVchRef { get; set; }  
 
		public Int32 PAVDPersRef { get; set; } 

        public void Validate()
        {
            new EditPayAccVchDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
