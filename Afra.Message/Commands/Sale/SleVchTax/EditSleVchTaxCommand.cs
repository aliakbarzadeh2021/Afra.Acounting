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
    public class EditSleVchTaxCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Nullable<Int32> SleVchHdrRef { get; set; }  
 
		public Int32 SleVchItmRef { get; set; }  
 
		public Int32 SVTTaxRef { get; set; }  
 
		public Nullable<Double> SVTTaxAmount { get; set; }  
 
		public Nullable<Double> SVTAmount { get; set; }  
 
		public Nullable<Double> SVTCurVal { get; set; } 

        public void Validate()
        {
            new EditSleVchTaxCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
