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
    public class AddSleBrokerSalaryRelsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SBSHdrRef { get; set; }  
 
		public Int32 SBSBrokerRef { get; set; } 

        public void Validate()
        {
            new AddSleBrokerSalaryRelsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
