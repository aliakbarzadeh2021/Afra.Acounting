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
    public class EditSleChngVchTaxCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Nullable<Int32> SleChngVchHdrRef { get; set; }  
 
		public Int32 SleChngVchItmRef { get; set; }  
 
		public Int32 SCVTTaxRef { get; set; }  
 
		public Nullable<Double> SCVTTaxAmount { get; set; }  
 
		public Nullable<Double> SCVTAmount { get; set; } 

        public void Validate()
        {
            new EditSleChngVchTaxCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
