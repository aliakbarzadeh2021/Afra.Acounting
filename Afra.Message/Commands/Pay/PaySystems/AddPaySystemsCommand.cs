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
    public class AddPaySystemsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PaySystemId { get; set; }  
 
		public String PSTitle { get; set; } 

        public void Validate()
        {
            new AddPaySystemsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
