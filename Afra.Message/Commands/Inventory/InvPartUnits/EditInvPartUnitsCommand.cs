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
    public class EditInvPartUnitsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PUPartRef { get; set; }  
 
		public Int32 PUUnitRef { get; set; }  
 
		public Nullable<Double> PURatio { get; set; }  
 
		public Nullable<Int32> PUCanChange { get; set; }  
 
		public Nullable<Int32> PUIsDef { get; set; } 

        public void Validate()
        {
            new EditInvPartUnitsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
