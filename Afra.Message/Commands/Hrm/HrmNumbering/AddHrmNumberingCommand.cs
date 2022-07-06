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
    public class AddHrmNumberingCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmNumberingId { get; set; }  
 
		public Int32 HNType { get; set; }  
 
		public String HNFormat { get; set; } 

        public void Validate()
        {
            new AddHrmNumberingCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
