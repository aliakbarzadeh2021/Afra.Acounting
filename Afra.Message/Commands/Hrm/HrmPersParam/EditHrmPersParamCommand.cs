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
    public class EditHrmPersParamCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmPersParamId { get; set; }  
 
		public String HPPTitle { get; set; } 

        public void Validate()
        {
            new EditHrmPersParamCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
