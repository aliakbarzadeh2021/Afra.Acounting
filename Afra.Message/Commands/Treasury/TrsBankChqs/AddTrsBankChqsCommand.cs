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
    public class AddTrsBankChqsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BankChqId { get; set; }  
 
		public Int32 BChqBeginSerial { get; set; }  
 
		public Int32 BChqShtCnt { get; set; }  
 
		public Int32 BChqAcnRef { get; set; }  
 
		public Nullable<Int32> BChqFmtRef { get; set; } 

        public void Validate()
        {
            new AddTrsBankChqsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
