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
    public class AddSMSMethodCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SMSMethodId { get; set; }  
 
		public String SMSMthdTitle { get; set; }  
 
		public Int32 SMSMthdType { get; set; }  
 
		public String SMSMthdSQL { get; set; }  
 
		public String SMSMthdText { get; set; } 

        public void Validate()
        {
            new AddSMSMethodCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
