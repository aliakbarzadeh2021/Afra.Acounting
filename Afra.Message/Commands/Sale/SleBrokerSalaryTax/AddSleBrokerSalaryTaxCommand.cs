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
    public class AddSleBrokerSalaryTaxCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SBSHdrRef { get; set; }  
 
		public Int32 SBSTaxRef { get; set; } 

        public void Validate()
        {
            new AddSleBrokerSalaryTaxCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
