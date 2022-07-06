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
    public class EditHrmGrpStatPersCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HGSPStatRef { get; set; }  
 
		public Int32 HGSPPersRef { get; set; } 

        public void Validate()
        {
            new EditHrmGrpStatPersCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
