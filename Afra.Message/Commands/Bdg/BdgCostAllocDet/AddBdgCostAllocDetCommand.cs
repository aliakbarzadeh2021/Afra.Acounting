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
    public class AddBdgCostAllocDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BCADHdrRef { get; set; }  
 
		public Int32 BCADCostCntrRef { get; set; }  
 
		public Nullable<Double> BCADAllocQty { get; set; } 

        public void Validate()
        {
            new AddBdgCostAllocDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
