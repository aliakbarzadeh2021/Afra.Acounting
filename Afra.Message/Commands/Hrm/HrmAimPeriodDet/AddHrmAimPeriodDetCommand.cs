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
    public class AddHrmAimPeriodDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HAPDPeriodRef { get; set; }  
 
		public Int32 HAPDPersRef { get; set; }  
 
		public Int32 HAPDElmntRef { get; set; }  
 
		public Nullable<Double> HAPDVal { get; set; } 

        public void Validate()
        {
            new AddHrmAimPeriodDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
