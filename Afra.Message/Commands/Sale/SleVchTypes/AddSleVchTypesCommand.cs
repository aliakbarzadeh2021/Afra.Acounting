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
    public class AddSleVchTypesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SleVchTypeId { get; set; }  
 
		public String SVTTitle { get; set; }  
 
		public Nullable<Int32> SVTInvVch { get; set; }  
 
		public Nullable<Int32> SVTBaseLimit { get; set; } 

        public void Validate()
        {
            new AddSleVchTypesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
