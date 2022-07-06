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
    public class EditPartFrmlOutCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PFOFrmlRef { get; set; }  
 
		public Int32 PFOPartRef { get; set; }  
 
		public Double PFOQty { get; set; } 

        public void Validate()
        {
            new EditPartFrmlOutCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
