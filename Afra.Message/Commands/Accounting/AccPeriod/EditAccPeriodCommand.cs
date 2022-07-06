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
    public class EditAccPeriodCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PeriodId { get; set; }  
 
		public String PeriodTitle { get; set; }  
 
		public DateTime p_FromDate { get; set; }  
 
		public DateTime p_ToDate { get; set; }  
 
		public Int32 p_Year { get; set; } 

        public void Validate()
        {
            new EditAccPeriodCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
