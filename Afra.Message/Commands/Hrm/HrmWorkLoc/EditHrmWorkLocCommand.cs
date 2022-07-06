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
    public class EditHrmWorkLocCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmWrkLocId { get; set; }  
 
		public String HWLTitle { get; set; } 

        public void Validate()
        {
            new EditHrmWorkLocCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
