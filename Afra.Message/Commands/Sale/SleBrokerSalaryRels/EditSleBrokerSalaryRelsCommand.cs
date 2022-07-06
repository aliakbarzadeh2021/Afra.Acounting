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
    public class EditSleBrokerSalaryRelsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SBSHdrRef { get; set; }  
 
		public Int32 SBSBrokerRef { get; set; } 

        public void Validate()
        {
            new EditSleBrokerSalaryRelsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
