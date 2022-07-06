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
    public class EditHrmAimElmntsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmAimElmntId { get; set; }  
 
		public String HAETitle { get; set; } 

        public void Validate()
        {
            new EditHrmAimElmntsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
