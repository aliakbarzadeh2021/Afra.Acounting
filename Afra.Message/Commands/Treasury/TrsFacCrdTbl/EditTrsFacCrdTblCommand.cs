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
    public class EditTrsFacCrdTblCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsFacCrdTblId { get; set; }  
 
		public String TFCTDescr { get; set; }  
 
		public DateTime TFCTDate { get; set; } 

        public void Validate()
        {
            new EditTrsFacCrdTblCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
