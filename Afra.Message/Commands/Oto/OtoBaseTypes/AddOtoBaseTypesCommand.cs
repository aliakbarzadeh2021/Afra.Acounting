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
    public class AddOtoBaseTypesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 OtoBaseTypeId { get; set; }  
 
		public String OBTTitle { get; set; } 

        public void Validate()
        {
            new AddOtoBaseTypesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
