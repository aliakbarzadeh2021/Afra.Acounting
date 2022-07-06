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
    public class AddAccVchTypesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 VchTypeId { get; set; }  
 
		public String VchTypeDescr { get; set; } 

        public void Validate()
        {
            new AddAccVchTypesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
