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
    public class EditCstStdAccDataCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CSADPeriodRef { get; set; }  
 
		public String CSADSLRef { get; set; }  
 
		public String CSADDLRef { get; set; }  
 
		public String CSADDLFive { get; set; }  
 
		public String CSADDLSix { get; set; }  
 
		public Nullable<Double> CSADDebit { get; set; }  
 
		public Nullable<Double> CSADCredit { get; set; } 

        public void Validate()
        {
            new EditCstStdAccDataCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
