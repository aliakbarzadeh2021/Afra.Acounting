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
    public class AddSleCtgryCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SleCtgryId { get; set; }  
 
		public String SCTitle { get; set; } 

        public void Validate()
        {
            new AddSleCtgryCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
