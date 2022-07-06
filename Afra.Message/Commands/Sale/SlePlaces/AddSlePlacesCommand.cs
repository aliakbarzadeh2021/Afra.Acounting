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
    public class AddSlePlacesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SalePlaceId { get; set; }  
 
		public String SalePlaceName { get; set; } 

        public void Validate()
        {
            new AddSlePlacesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
