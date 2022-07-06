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
    public class AddOtoQuickNoteCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 OtoQuickNoteId { get; set; }  
 
		public String OQNTitle { get; set; }  
 
		public Byte[] OQNText { get; set; } 

        public void Validate()
        {
            new AddOtoQuickNoteCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
