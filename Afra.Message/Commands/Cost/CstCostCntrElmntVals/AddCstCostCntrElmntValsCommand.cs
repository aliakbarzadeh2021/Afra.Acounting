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
    public class AddCstCostCntrElmntValsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CCnEVElmntRef { get; set; }  
 
		public Int32 CCnEVCostCntRef { get; set; }  
 
		public Int32 CCnEVPeriodId { get; set; }  
 
		public Nullable<Double> CCnEVAmount { get; set; } 

        public void Validate()
        {
            new AddCstCostCntrElmntValsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
