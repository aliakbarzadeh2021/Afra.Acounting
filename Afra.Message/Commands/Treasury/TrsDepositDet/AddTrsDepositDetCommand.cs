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
    public class AddTrsDepositDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsDepositDetId { get; set; }  
 
		public Nullable<Int32> TDDType { get; set; }  
 
		public Nullable<Int32> TDDDeptRef { get; set; }  
 
		public DateTime TDDDate { get; set; }  
 
		public Nullable<Double> TDDAmount { get; set; }  
 
		public String TDDDescr { get; set; } 

        public void Validate()
        {
            new AddTrsDepositDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
