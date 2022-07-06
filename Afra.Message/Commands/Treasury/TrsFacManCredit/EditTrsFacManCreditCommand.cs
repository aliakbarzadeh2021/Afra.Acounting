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
    public class EditTrsFacManCreditCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsFacManCreditId { get; set; }  
 
		public Int32 TFMCCrspndRef { get; set; }  
 
		public Int32 TFMCType { get; set; }  
 
		public Double TFMCAmount { get; set; }  
 
		public String TFMCDescr { get; set; } 

        public void Validate()
        {
            new EditTrsFacManCreditCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
