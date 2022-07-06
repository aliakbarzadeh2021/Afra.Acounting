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
    public class EditAccNoteHdrCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AccNoteHdrId { get; set; }  
 
		public Int32 ANHNum { get; set; }  
 
		public DateTime ANHDate { get; set; }  
 
		public String ANHDescr { get; set; }  
 
		public String ANHDLRef { get; set; } 

        public void Validate()
        {
            new EditAccNoteHdrCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
