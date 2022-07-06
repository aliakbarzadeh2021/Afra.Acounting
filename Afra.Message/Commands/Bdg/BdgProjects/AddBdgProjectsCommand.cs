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
    public class AddBdgProjectsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BdgProjectId { get; set; }  
 
		public Int32 BPPrjRef { get; set; }  
 
		public Int32 BPType { get; set; }  
 
		public String BPDescr { get; set; }  
 
		public Int32 BPPeriodRef { get; set; } 

        public void Validate()
        {
            new AddBdgProjectsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
