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
    public class EditTrsBankChqsDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsBankChqDetId { get; set; }  
 
		public Int32 TBCDHdrRef { get; set; }  
 
		public Int32 TBCDChqNo { get; set; }  
 
		public Int32 TBCDSit { get; set; } 

        public void Validate()
        {
            new EditTrsBankChqsDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
