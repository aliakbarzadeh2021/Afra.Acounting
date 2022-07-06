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
    public class EditTrsGuaranteeGuaCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsGuaranteeGuaId { get; set; }  
 
		public Int32 TGGGuaRef { get; set; }  
 
		public Nullable<Int32> TGGRcvDocId { get; set; }  
 
		public String TGGDescr { get; set; } 

        public void Validate()
        {
            new EditTrsGuaranteeGuaCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
