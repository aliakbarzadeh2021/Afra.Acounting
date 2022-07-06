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
    public class AddTrsBankReconcileCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsBankReconcileId { get; set; }  
 
		public Int32 TBRBankBillRef { get; set; }  
 
		public String TBRNum { get; set; }  
 
		public DateTime TBRDate { get; set; } 

        public void Validate()
        {
            new AddTrsBankReconcileCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
