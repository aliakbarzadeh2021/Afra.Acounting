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
    public class EditGnrRefFormsListDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 RFLDHdrRef { get; set; }  
 
		public String RFLDFieldName { get; set; }  
 
		public String RFLDTitle { get; set; } 

        public void Validate()
        {
            new EditGnrRefFormsListDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
