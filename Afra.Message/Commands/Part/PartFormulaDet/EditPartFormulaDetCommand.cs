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
    public class EditPartFormulaDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PartFrmlDetId { get; set; }  
 
		public Int32 PFDHdrRef { get; set; }  
 
		public Int32 PFDPartRef { get; set; }  
 
		public Nullable<Double> PFDQtyRatio { get; set; }  
 
		public Nullable<Double> PFDWast { get; set; } 

        public void Validate()
        {
            new EditPartFormulaDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
