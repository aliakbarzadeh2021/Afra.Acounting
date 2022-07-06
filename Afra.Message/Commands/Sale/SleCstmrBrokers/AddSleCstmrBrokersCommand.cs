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
    public class AddSleCstmrBrokersCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SleCstmrRef { get; set; }  
 
		public Int32 SleBrokerRef { get; set; } 

        public void Validate()
        {
            new AddSleCstmrBrokersCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
