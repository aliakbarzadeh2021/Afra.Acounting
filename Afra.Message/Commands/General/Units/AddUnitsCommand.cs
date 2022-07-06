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
    public class AddUnitsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 UnitId { get; set; }  
 
		public String UnitName { get; set; } 

        public void Validate()
        {
            new AddUnitsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
