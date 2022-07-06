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
    public class EditCurrencyCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CurrencyId { get; set; }  
 
		public String CurTitle { get; set; }  
 
		public Nullable<Int32> CurDigitCnt { get; set; }  
 
		public String CurDigitTitle { get; set; } 

        public void Validate()
        {
            new EditCurrencyCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
