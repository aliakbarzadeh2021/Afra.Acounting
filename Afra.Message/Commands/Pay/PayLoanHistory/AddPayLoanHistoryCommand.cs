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
    public class AddPayLoanHistoryCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayLoanHostoryId { get; set; }  
 
		public Int32 PLHLoanRef { get; set; }  
 
		public Nullable<Int32> PLHState { get; set; }  
 
		public Int32 PLHIYearMonth { get; set; } 

        public void Validate()
        {
            new AddPayLoanHistoryCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
