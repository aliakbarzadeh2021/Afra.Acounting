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
    public class AddTrsCalcFormulaCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsCalcFormulId { get; set; }  
 
		public Int32 TFCType { get; set; }  
 
		public Nullable<Int32> TFCKind { get; set; }  
 
		public String TFCFormula { get; set; }  
 
		public String TFCInstCalc { get; set; } 

        public void Validate()
        {
            new AddTrsCalcFormulaCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
