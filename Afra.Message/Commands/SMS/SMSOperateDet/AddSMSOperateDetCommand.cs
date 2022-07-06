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
    public class AddSMSOperateDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SMSOperateDetId { get; set; }  
 
		public DateTime SMSOperateDate { get; set; }  
 
		public Int32 SMSOperateRef { get; set; }  
 
		public String SODNumber { get; set; }  
 
		public String SODDeliver { get; set; }  
 
		public String SODText { get; set; }  
 
		public DateTime SODSendDate { get; set; }  
 
		public DateTime SODRcvDate { get; set; }  
 
		public Nullable<Int32> SODSit { get; set; }  
 
		public String SODRefId { get; set; }  
 
		public String SODError { get; set; } 

        public void Validate()
        {
            new AddSMSOperateDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
