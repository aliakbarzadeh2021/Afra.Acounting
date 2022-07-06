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
    public class AddHrmAimPeriodCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmAimPeriodId { get; set; }  
 
		public String HAPTitle { get; set; }  
 
		public DateTime HAPDate { get; set; }  
 
		public Nullable<Int32> HAPFormRef { get; set; } 

        public void Validate()
        {
            new AddHrmAimPeriodCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
