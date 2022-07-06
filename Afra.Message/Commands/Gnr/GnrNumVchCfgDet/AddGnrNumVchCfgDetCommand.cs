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
    public class AddGnrNumVchCfgDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GNVCHdrRef { get; set; }  
 
		public Int32 GNVCVchTyp { get; set; } 

        public void Validate()
        {
            new AddGnrNumVchCfgDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
