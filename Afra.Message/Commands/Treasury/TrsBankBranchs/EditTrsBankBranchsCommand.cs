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
    public class EditTrsBankBranchsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BankBranchId { get; set; }  
 
		public String BankBranchName { get; set; }  
 
		public String BankBranchCode { get; set; }  
 
		public Int32 BBBankRef { get; set; }  
 
		public String BankBranchType { get; set; } 

        public void Validate()
        {
            new EditTrsBankBranchsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
