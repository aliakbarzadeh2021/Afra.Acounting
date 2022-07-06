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
    public class EditAccNoteItmCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AccNoteItmId { get; set; }  
 
		public Int32 AccNoteHdrRef { get; set; }  
 
		public String ANISLRef { get; set; }  
 
		public DateTime ANIItmDate { get; set; }  
 
		public String ANIDescr { get; set; }  
 
		public Nullable<Double> ANIDebit { get; set; }  
 
		public Nullable<Double> ANICredit { get; set; } 

        public void Validate()
        {
            new EditAccNoteItmCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
