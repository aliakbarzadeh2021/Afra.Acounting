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
    public class AddGnrLimitExceptCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GnrLimitExceptId { get; set; }  
 
		public Int32 GLEGroupRef { get; set; }  
 
		public Int32 GLEUserRef { get; set; } 

        public void Validate()
        {
            new AddGnrLimitExceptCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
