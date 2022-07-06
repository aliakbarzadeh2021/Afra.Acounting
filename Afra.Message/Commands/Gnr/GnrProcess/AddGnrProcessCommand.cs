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
    public class AddGnrProcessCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GnrProcessId { get; set; }  
 
		public String GPTitle { get; set; } 

        public void Validate()
        {
            new AddGnrProcessCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
