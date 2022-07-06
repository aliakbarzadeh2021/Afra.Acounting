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
    public class EditQcsTestsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 QcsTestsId { get; set; }  
 
		public Int32 QTPartRef { get; set; }  
 
		public String QTStepName { get; set; }  
 
		public String QTName { get; set; }  
 
		public Int32 QTLabRef { get; set; }  
 
		public Int32 QTRepeat { get; set; } 

        public void Validate()
        {
            new EditQcsTestsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
