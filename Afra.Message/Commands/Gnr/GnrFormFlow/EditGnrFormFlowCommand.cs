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
    public class EditGnrFormFlowCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GnrFormFlowId { get; set; }  
 
		public String GFFTitle { get; set; }  
 
		public String GFFName { get; set; } 

        public void Validate()
        {
            new EditGnrFormFlowCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
