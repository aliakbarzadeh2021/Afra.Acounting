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
    public class EditHrmGrpParamStatAmntCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HGPSParamRef { get; set; }  
 
		public Int32 HGPSStatRef { get; set; }  
 
		public Nullable<Double> HGPSAmount { get; set; }  
 
		public Nullable<Int32> HGPSSit { get; set; } 

        public void Validate()
        {
            new EditHrmGrpParamStatAmntCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
