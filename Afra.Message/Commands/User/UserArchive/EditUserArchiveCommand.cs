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
    public class EditUserArchiveCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 UserArchiveId { get; set; }  
 
		public Int32 UATypeRef { get; set; }  
 
		public String UADescr { get; set; }  
 
		public String UAFileName { get; set; }  
 
		public Byte[] UAData { get; set; } 

        public void Validate()
        {
            new EditUserArchiveCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
