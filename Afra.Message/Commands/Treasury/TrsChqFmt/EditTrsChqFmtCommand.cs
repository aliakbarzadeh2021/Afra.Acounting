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
    public class EditTrsChqFmtCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsChqFmtId { get; set; }  
 
		public String TCFTitle { get; set; }  
 
		public String TCFFile { get; set; } 

        public void Validate()
        {
            new EditTrsChqFmtCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
