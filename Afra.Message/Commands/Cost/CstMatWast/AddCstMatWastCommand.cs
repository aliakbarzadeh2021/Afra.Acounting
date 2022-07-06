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
    public class AddCstMatWastCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CstMatWastId { get; set; }  
 
		public Nullable<Int32> CMWPeriodId { get; set; }  
 
		public DateTime CMWDate { get; set; }  
 
		public Nullable<Int32> CMWCostCntrRef { get; set; }  
 
		public Nullable<Int32> CMWPartRef { get; set; }  
 
		public Nullable<Double> CMWQty { get; set; } 

        public void Validate()
        {
            new AddCstMatWastCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
