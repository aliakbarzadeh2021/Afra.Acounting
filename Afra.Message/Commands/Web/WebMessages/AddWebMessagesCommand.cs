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
    public class AddWebMessagesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 WebMsgId { get; set; }  
 
		public String WMNatCode { get; set; }  
 
		public DateTime WMSndDate { get; set; }  
 
		public DateTime WMRcvDate { get; set; }  
 
		public String WMTitle { get; set; }  
 
		public String WMMsg { get; set; } 

        public void Validate()
        {
            new AddWebMessagesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
