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
    public class AddCurrencyCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CurrencyId { get; set; }  
 
		public String CurTitle { get; set; }  
 
		public Nullable<Int32> CurDigitCnt { get; set; }  
 
		public String CurDigitTitle { get; set; } 

        public void Validate()
        {
            new AddCurrencyCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
