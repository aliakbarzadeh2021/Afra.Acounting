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
    public class EditBdgHrmValsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BdgHrmValsId { get; set; }  
 
		public Int32 BHVCostCntrRef { get; set; }  
 
		public Int32 BHVElmntRef { get; set; }  
 
		public Double BHVAmount { get; set; }  
 
		public Int32 BHVPeriodRef { get; set; }  
 
		public Nullable<Int32> BHVCurRef { get; set; } 

        public void Validate()
        {
            new EditBdgHrmValsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
