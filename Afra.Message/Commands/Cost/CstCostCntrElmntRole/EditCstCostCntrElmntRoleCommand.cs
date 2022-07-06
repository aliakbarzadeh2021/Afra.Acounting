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
    public class EditCstCostCntrElmntRoleCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CCnERCostCntRef { get; set; }  
 
		public Int32 CCnERElmntRef { get; set; }  
 
		public Int32 CCnERRoleRef { get; set; }  
 
		public Int32 CCnERPeriodId { get; set; }  
 
		public Nullable<Double> CCnERFixPrc { get; set; } 

        public void Validate()
        {
            new EditCstCostCntrElmntRoleCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
