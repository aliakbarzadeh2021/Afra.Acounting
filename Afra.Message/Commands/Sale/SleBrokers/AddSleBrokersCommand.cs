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
    public class AddSleBrokersCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SleBrokerId { get; set; }  
 
		public Int32 SBCrspndRef { get; set; } 

        public void Validate()
        {
            new AddSleBrokersCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
