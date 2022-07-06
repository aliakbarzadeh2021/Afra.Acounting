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
    public class AddGnrFormFlowCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GnrFormFlowId { get; set; }  
 
		public String GFFTitle { get; set; }  
 
		public String GFFName { get; set; } 

        public void Validate()
        {
            new AddGnrFormFlowCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
