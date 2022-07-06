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
    public class EditPayLoanPaymentCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayLoanPaymentId { get; set; }  
 
		public Nullable<Int32> PLPLoanRef { get; set; }  
 
		public Nullable<Int32> PLPYearNum { get; set; }  
 
		public Nullable<Int32> PLPMonthNum { get; set; }  
 
		public Nullable<Double> PLPAmount { get; set; }  
 
		public Nullable<Int32> PLPYearMonth { get; set; }  
 
		public Nullable<Int32> PLPType { get; set; }  
 
		public String PLPDescr { get; set; } 

        public void Validate()
        {
            new EditPayLoanPaymentCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
