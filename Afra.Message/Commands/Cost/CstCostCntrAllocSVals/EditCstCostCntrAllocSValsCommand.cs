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
    public class EditCstCostCntrAllocSValsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CstCostCntrAllocSValId { get; set; }  
 
		public Int32 CCASVPutCostId { get; set; }  
 
		public Int32 CCASVRcvCostId { get; set; }  
 
		public String CCASVSLRef { get; set; }  
 
		public Nullable<Double> CCASVValue { get; set; }  
 
		public Int32 CCASVPeriodId { get; set; } 

        public void Validate()
        {
            new EditCstCostCntrAllocSValsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
