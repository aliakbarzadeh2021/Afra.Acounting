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
    public class EditCntExpAcntCostCntrCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntExpAcntCostCntrId { get; set; }  
 
		public Int32 CEACExpAcntRef { get; set; }  
 
		public Int32 CEACCostRef { get; set; }  
 
		public Double CEACAmount { get; set; }  
 
		public Nullable<Double> CEACCurVal { get; set; } 

        public void Validate()
        {
            new EditCntExpAcntCostCntrCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
