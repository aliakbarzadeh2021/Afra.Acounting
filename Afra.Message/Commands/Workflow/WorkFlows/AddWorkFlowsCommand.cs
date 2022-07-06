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
    public class AddWorkFlowsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 WorkFlowId { get; set; }  
 
		public String WFTitle { get; set; }  
 
		public Int32 WFType { get; set; }  
 
		public Nullable<Int32> WFState { get; set; } 

        public void Validate()
        {
            new AddWorkFlowsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
