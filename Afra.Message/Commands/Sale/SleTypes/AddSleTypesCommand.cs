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
    public class AddSleTypesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SaleTypeId { get; set; }  
 
		public String SaleTypeName { get; set; } 

        public void Validate()
        {
            new AddSleTypesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
