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
    public class EditGnrReportsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 RptId { get; set; }  
 
		public Int32 RptGroupRef { get; set; }  
 
		public String RptTitle { get; set; }  
 
		public String RptQuery { get; set; }  
 
		public String RptFile { get; set; }  
 
		public String RptDef { get; set; } 

        public void Validate()
        {
            new EditGnrReportsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
