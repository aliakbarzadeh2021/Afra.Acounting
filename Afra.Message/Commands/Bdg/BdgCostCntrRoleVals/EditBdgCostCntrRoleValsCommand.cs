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
    public class EditBdgCostCntrRoleValsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BCnRVRoleRef { get; set; }  
 
		public Int32 BCnRVCostCntRef { get; set; }  
 
		public Int32 BCnRVPeriodId { get; set; }  
 
		public Nullable<Double> BCnRVAmount { get; set; } 

        public void Validate()
        {
            new EditBdgCostCntrRoleValsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
