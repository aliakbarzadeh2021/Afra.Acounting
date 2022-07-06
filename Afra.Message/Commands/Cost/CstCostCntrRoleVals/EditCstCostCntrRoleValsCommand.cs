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
    public class EditCstCostCntrRoleValsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CCnRVRoleRef { get; set; }  
 
		public Int32 CCnRVCostCntRef { get; set; }  
 
		public Int32 CCnRVPeriodId { get; set; }  
 
		public Nullable<Double> CCnRVAmount { get; set; } 

        public void Validate()
        {
            new EditCstCostCntrRoleValsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
