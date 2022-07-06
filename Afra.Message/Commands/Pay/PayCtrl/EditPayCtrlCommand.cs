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
    public class EditPayCtrlCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayCtrlId { get; set; }  
 
		public Int32 PCtYear { get; set; }  
 
		public Int32 PCtMonth { get; set; } 

        public void Validate()
        {
            new EditPayCtrlCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
