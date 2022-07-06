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
    public class EditTrsManCreditCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsManCreditId { get; set; }  
 
		public Int32 TMCType { get; set; }  
 
		public Int32 TMCCrspndRef { get; set; }  
 
		public Int32 TMCKind { get; set; }  
 
		public Double TMCAmount { get; set; }  
 
		public String TMCDescr { get; set; } 

        public void Validate()
        {
            new EditTrsManCreditCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
