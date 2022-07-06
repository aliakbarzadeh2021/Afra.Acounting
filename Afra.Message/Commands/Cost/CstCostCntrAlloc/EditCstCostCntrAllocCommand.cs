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
    public class EditCstCostCntrAllocCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CstCostCntAllocId { get; set; }  
 
		public Nullable<Int32> CCnACostCntRef { get; set; }  
 
		public Nullable<Int32> CCnARoleRef { get; set; }  
 
		public Nullable<Int32> CCnAPeriodId { get; set; }  
 
		public Nullable<Double> CCnAPrc { get; set; } 

        public void Validate()
        {
            new EditCstCostCntrAllocCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
