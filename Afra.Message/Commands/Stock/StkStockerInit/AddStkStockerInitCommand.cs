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
    public class AddStkStockerInitCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SSIPeriodRef { get; set; }  
 
		public Int32 SSIStockerRef { get; set; }  
 
		public Nullable<Double> SSIQty { get; set; }  
 
		public Nullable<Double> SSIDebit { get; set; }  
 
		public Nullable<Double> SSICredit { get; set; } 

        public void Validate()
        {
            new AddStkStockerInitCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
