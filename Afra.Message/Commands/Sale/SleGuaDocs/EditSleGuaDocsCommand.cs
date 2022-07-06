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
    public class EditSleGuaDocsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SleGuaDocId { get; set; }  
 
		public String SGDNum { get; set; }  
 
		public Int32 SGDFactRef { get; set; }  
 
		public DateTime SGDStDate { get; set; }  
 
		public DateTime SGDEnDate { get; set; }  
 
		public String SGDDescr { get; set; } 

        public void Validate()
        {
            new EditSleGuaDocsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
