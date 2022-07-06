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
    public class EditCmrLCDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CmrLCDetId { get; set; }  
 
		public Int32 CmrLCRef { get; set; }  
 
		public String CLDDescr { get; set; }  
 
		public Double CLDAmount { get; set; } 

        public void Validate()
        {
            new EditCmrLCDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
