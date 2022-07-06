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
    public class EditCstProductVchCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CstProductVchId { get; set; }  
 
		public Int32 CPVPeriodId { get; set; }  
 
		public Int32 CPVPartRef { get; set; }  
 
		public Int32 CPVFormulaRef { get; set; }  
 
		public Int32 CPVCostCntrRef { get; set; }  
 
		public Int32 CPVNum { get; set; }  
 
		public DateTime CPVDate { get; set; }  
 
		public Int32 CPVType { get; set; }  
 
		public Double CPVQty { get; set; } 

        public void Validate()
        {
            new EditCstProductVchCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
