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
    public class AddCmrServicesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CmrServicesId { get; set; }  
 
		public String CSCode { get; set; }  
 
		public String CSTitle { get; set; } 

        public void Validate()
        {
            new AddCmrServicesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
