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
    public class AddCstCostAllocDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CCADHdrRef { get; set; }  
 
		public Int32 CCADCostCntrRef { get; set; }  
 
		public Nullable<Double> CCADAllocQty { get; set; } 

        public void Validate()
        {
            new AddCstCostAllocDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
