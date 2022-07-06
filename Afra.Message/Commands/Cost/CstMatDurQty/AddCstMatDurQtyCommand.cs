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
    public class AddCstMatDurQtyCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CstMatDurQtyId { get; set; }  
 
		public Nullable<Int32> CMDQType { get; set; }  
 
		public Nullable<Int32> CMDQPartRef { get; set; }  
 
		public Nullable<Int32> CMDQCostCntrRef { get; set; }  
 
		public Nullable<Int32> CMDQPeriodId { get; set; }  
 
		public Nullable<Double> CMDQQty { get; set; }  
 
		public Nullable<Double> CMDQAmount { get; set; } 

        public void Validate()
        {
            new AddCstMatDurQtyCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
