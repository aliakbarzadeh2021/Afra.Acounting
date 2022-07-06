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
    public class AddStkPeriodsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 StkPeriodId { get; set; }  
 
		public String SPTitle { get; set; }  
 
		public DateTime SPFromDate { get; set; }  
 
		public DateTime SPToDate { get; set; }  
 
		public Nullable<Int32> SPState { get; set; } 

        public void Validate()
        {
            new AddStkPeriodsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
