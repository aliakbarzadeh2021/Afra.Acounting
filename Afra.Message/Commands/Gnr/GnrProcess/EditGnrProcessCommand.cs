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
    public class EditGnrProcessCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GnrProcessId { get; set; }  
 
		public String GPTitle { get; set; } 

        public void Validate()
        {
            new EditGnrProcessCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
