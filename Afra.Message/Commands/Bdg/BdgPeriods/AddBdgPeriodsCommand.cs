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
    public class AddBdgPeriodsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BdgPeriodId { get; set; }  
 
		public String BPTitle { get; set; }  
 
		public DateTime BPFromDate { get; set; }  
 
		public DateTime BPToDate { get; set; }  
 
		public Nullable<Int32> BPState { get; set; }  
 
		public DateTime BPRepDate { get; set; }  
 
		public DateTime BPOpFDate { get; set; }  
 
		public DateTime BPOpTDate { get; set; } 

        public void Validate()
        {
            new AddBdgPeriodsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
