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
    public class EditGnrProcessDetArchCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GPDAHdrRef { get; set; }  
 
		public Int32 GPDAArchRef { get; set; }  
 
		public Nullable<Int32> GPDAForce { get; set; } 

        public void Validate()
        {
            new EditGnrProcessDetArchCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
