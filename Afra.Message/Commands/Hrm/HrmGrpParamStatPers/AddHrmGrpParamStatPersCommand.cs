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
    public class AddHrmGrpParamStatPersCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HGPSStatRef { get; set; }  
 
		public Int32 HGPSPersRef { get; set; } 

        public void Validate()
        {
            new AddHrmGrpParamStatPersCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
