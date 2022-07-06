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
    public class AddCstMatQtyCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CstMatQtyId { get; set; }  
 
		public Nullable<Int32> CMQPeriodId { get; set; }  
 
		public Nullable<Int32> CMQCostCntrRef { get; set; }  
 
		public Nullable<Int32> CMQPartRef { get; set; }  
 
		public Nullable<Double> CMQQty { get; set; }  
 
		public Nullable<Double> CMQAmount { get; set; } 

        public void Validate()
        {
            new AddCstMatQtyCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
