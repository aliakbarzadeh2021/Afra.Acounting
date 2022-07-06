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
    public class EditSleBrokerSalaryTaxCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SBSHdrRef { get; set; }  
 
		public Int32 SBSTaxRef { get; set; } 

        public void Validate()
        {
            new EditSleBrokerSalaryTaxCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
