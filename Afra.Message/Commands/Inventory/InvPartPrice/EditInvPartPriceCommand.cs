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
    public class EditInvPartPriceCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 IPPPartRef { get; set; }  
 
		public Int32 IIPAccPrdRef { get; set; }  
 
		public Nullable<Double> IPPRatio { get; set; }  
 
		public Int32 IPPType { get; set; } 

        public void Validate()
        {
            new EditInvPartPriceCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
