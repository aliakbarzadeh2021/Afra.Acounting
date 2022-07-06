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
    public class EditCntExpAcntDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntExpAcntDetId { get; set; }  
 
		public Int32 CEADItemRef { get; set; }  
 
		public Int32 CEADExpAcntRef { get; set; }  
 
		public Double CEADQty { get; set; }  
 
		public Nullable<Int32> CEADDur { get; set; } 

        public void Validate()
        {
            new EditCntExpAcntDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
