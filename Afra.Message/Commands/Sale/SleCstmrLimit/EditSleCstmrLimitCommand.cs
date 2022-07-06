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
    public class EditSleCstmrLimitCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SleCstmrLimitId { get; set; }  
 
		public Int32 SCLCstmrRef { get; set; }  
 
		public DateTime SCLDate { get; set; }  
 
		public Nullable<Double> SCLAmount { get; set; } 

        public void Validate()
        {
            new EditSleCstmrLimitCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
