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
    public class AddTrsGContractChngCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsGuaContractChngId { get; set; }  
 
		public Int32 TrsGuaContractRef { get; set; }  
 
		public DateTime TGCCDate { get; set; }  
 
		public String TGCCDescr { get; set; }  
 
		public Nullable<Double> TGCCAmount { get; set; } 

        public void Validate()
        {
            new AddTrsGContractChngCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
