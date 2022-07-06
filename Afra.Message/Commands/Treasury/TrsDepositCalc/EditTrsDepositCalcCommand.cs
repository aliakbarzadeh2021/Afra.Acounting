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
    public class EditTrsDepositCalcCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsDepositCalcId { get; set; }  
 
		public Int32 TDCItemRef { get; set; }  
 
		public Int32 TDCYear { get; set; }  
 
		public Int32 TDCMonth { get; set; }  
 
		public Double TDCAmount { get; set; } 

        public void Validate()
        {
            new EditTrsDepositCalcCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
