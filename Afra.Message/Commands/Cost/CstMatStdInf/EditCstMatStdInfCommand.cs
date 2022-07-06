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
    public class EditCstMatStdInfCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CMSMatRef { get; set; }  
 
		public Nullable<Double> CMSAmnt { get; set; }  
 
		public Nullable<Double> CMSRatio { get; set; }  
 
		public Int32 CMSPeriodId { get; set; } 

        public void Validate()
        {
            new EditCstMatStdInfCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
