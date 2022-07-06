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
    public class AddCstCostCntrFillCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CCnFCostCenter { get; set; }  
 
		public Int32 CCnFPeriodId { get; set; }  
 
		public Nullable<Double> CCnFHrmTime { get; set; }  
 
		public Nullable<Double> CCnFCstTime { get; set; }  
 
		public Nullable<Double> CCnFPkgHrmTime { get; set; }  
 
		public Nullable<Double> CCnFPkgCstTime { get; set; } 

        public void Validate()
        {
            new AddCstCostCntrFillCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
