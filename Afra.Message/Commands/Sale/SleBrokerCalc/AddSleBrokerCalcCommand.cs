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
    public class AddSleBrokerCalcCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SleBrokerCalcId { get; set; }  
 
		public Int32 SBCSalaryRef { get; set; }  
 
		public Int32 SBCBrokerRef { get; set; }  
 
		public DateTime SBCFDate { get; set; }  
 
		public DateTime SBCEDate { get; set; }  
 
		public Double SBCBaseAmnt { get; set; }  
 
		public Double SBCAmount { get; set; } 

        public void Validate()
        {
            new AddSleBrokerCalcCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
