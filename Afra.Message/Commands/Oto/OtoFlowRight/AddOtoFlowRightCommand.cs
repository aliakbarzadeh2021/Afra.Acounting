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
    public class AddOtoFlowRightCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 OtoFlowRightId { get; set; }  
 
		public Int32 OFRUserRef { get; set; }  
 
		public Int32 OFRToUser { get; set; }  
 
		public Nullable<Int32> OFRRight { get; set; } 

        public void Validate()
        {
            new AddOtoFlowRightCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
