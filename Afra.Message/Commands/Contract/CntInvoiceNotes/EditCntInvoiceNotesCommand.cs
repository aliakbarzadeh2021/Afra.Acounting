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
    public class EditCntInvoiceNotesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntInvoiceNoteId { get; set; }  
 
		public String CINTitle { get; set; }  
 
		public String CINFormul { get; set; } 

        public void Validate()
        {
            new EditCntInvoiceNotesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
