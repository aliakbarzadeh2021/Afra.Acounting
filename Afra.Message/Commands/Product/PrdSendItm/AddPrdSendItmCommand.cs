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
    public class AddPrdSendItmCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PrdSendItmId { get; set; }  
 
		public Int32 PSISeq { get; set; }  
 
		public Int32 PrdSendHdrRef { get; set; }  
 
		public Nullable<Int32> PSIOprRef { get; set; }  
 
		public Nullable<Double> PSIMainQty { get; set; }  
 
		public String PSIDescr { get; set; } 

        public void Validate()
        {
            new AddPrdSendItmCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
