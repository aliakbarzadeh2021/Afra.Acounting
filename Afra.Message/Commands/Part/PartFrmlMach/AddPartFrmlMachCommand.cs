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
    public class AddPartFrmlMachCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PFMFrmlRef { get; set; }  
 
		public Int32 PFMMachRef { get; set; } 

        public void Validate()
        {
            new AddPartFrmlMachCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
