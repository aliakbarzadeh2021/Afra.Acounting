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
    public class AddTrsBankAccountsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BankAccountId { get; set; }  
 
		public String BankAccountNo { get; set; }  
 
		public Int32 BABrnchRef { get; set; }  
 
		public String BankAccountType { get; set; }  
 
		public Nullable<Double> BAFirstQty { get; set; }  
 
		public DateTime BAOpenDate { get; set; }  
 
		public String BADLRef { get; set; }  
 
		public DateTime BAReconDate { get; set; }  
 
		public Nullable<Double> BAReconRem { get; set; }  
 
		public Nullable<Int32> BARemWithInst { get; set; } 

        public void Validate()
        {
            new AddTrsBankAccountsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
