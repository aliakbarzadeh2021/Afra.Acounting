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
    public class AddOtoFlowCrsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 OtoFlowRef { get; set; }  
 
		public Int32 OFCUserRef { get; set; }  
 
		public DateTime OFCRcvDate { get; set; } 

        public void Validate()
        {
            new AddOtoFlowCrsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
