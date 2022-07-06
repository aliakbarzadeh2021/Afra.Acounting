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
    public class EditGnrNumVchCfgDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GNVCHdrRef { get; set; }  
 
		public Int32 GNVCVchTyp { get; set; } 

        public void Validate()
        {
            new EditGnrNumVchCfgDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
