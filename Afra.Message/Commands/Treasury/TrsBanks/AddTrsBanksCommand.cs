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
    public class AddTrsBanksCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsBankId { get; set; }  
 
		public String TrsBankName { get; set; } 

        public void Validate()
        {
            new AddTrsBanksCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
