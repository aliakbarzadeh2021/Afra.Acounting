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
    public class EditBdgCostCntrAllocCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BdgCostCntAllocId { get; set; }  
 
		public Nullable<Int32> BCnACostCntRef { get; set; }  
 
		public Nullable<Int32> BCnAElmntRef { get; set; }  
 
		public Nullable<Int32> BCnARoleRef { get; set; }  
 
		public Nullable<Int32> BCnAPeriodId { get; set; }  
 
		public Nullable<Double> BCnAPrc { get; set; } 

        public void Validate()
        {
            new EditBdgCostCntrAllocCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
