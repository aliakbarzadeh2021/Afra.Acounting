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
    public class AddWebLoginsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 WebLoginId { get; set; }  
 
		public String WLNatCode { get; set; }  
 
		public String WLPCName { get; set; }  
 
		public DateTime WLDateTime { get; set; }  
 
		public DateTime WLExit { get; set; }  
 
		public Int32 WLState { get; set; } 

        public void Validate()
        {
            new AddWebLoginsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
