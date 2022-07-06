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
    public class EditOtoBaseTypesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 OtoBaseTypeId { get; set; }  
 
		public String OBTTitle { get; set; } 

        public void Validate()
        {
            new EditOtoBaseTypesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
