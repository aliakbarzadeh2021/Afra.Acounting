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
    public class AddHrmAimElmntsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmAimElmntId { get; set; }  
 
		public String HAETitle { get; set; } 

        public void Validate()
        {
            new AddHrmAimElmntsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
