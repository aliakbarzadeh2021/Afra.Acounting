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
    public class EditPayGrpValStatPersCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PGVSStatRef { get; set; }  
 
		public Int32 PGVSPersRef { get; set; } 

        public void Validate()
        {
            new EditPayGrpValStatPersCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
