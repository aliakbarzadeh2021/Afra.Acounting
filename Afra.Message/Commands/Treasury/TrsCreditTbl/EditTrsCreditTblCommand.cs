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
    public class EditTrsCreditTblCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsCreditTblId { get; set; }  
 
		public Nullable<Int32> TCTType { get; set; }  
 
		public String TCTDescr { get; set; }  
 
		public DateTime TCTDate { get; set; } 

        public void Validate()
        {
            new EditTrsCreditTblCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
