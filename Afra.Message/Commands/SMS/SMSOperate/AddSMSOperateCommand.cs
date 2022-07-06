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
    public class AddSMSOperateCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SMSOperateId { get; set; }  
 
		public Int32 SMSMethodRef { get; set; }  
 
		public Nullable<Int32> SMSRole { get; set; }  
 
		public Nullable<Int32> SMSDur { get; set; }  
 
		public Nullable<Double> SMSDelay { get; set; }  
 
		public DateTime SMSStartDate { get; set; } 

        public void Validate()
        {
            new AddSMSOperateCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
