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
    public class AddHrmParamStatAmntCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HPSAStatRef { get; set; }  
 
		public Int32 HPSAParamRef { get; set; }  
 
		public Nullable<Double> HPSAAmount { get; set; } 

        public void Validate()
        {
            new AddHrmParamStatAmntCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
