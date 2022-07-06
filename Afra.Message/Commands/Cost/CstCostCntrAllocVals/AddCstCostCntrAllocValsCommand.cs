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
    public class AddCstCostCntrAllocValsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CstCostCntrAllocValId { get; set; }  
 
		public Int32 CCAVPutCostId { get; set; }  
 
		public Int32 CCAVRcvCostId { get; set; }  
 
		public String CCAVSLRef { get; set; }  
 
		public Nullable<Double> CCAVValue { get; set; }  
 
		public Int32 CCAVPeriodId { get; set; } 

        public void Validate()
        {
            new AddCstCostCntrAllocValsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
