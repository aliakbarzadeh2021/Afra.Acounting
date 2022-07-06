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
    public class AddSleGuaranteeCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SleGuaranteeId { get; set; }  
 
		public String SGTitle { get; set; }  
 
		public String SGSLRef { get; set; }  
 
		public Nullable<Int32> SGDL4Type { get; set; }  
 
		public Nullable<Int32> SGDL5Type { get; set; }  
 
		public Nullable<Int32> SGDL6Type { get; set; } 

        public void Validate()
        {
            new AddSleGuaranteeCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
