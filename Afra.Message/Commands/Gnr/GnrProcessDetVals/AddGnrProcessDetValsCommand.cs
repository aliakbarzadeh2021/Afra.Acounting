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
    public class AddGnrProcessDetValsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GPDVHdrRef { get; set; }  
 
		public Int32 GPDVItmRef { get; set; }  
 
		public String GPDVVal { get; set; } 

        public void Validate()
        {
            new AddGnrProcessDetValsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
