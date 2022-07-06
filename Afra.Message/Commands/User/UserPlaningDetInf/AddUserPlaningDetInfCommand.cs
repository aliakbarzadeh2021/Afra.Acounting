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
    public class AddUserPlaningDetInfCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 UPDIItmRef { get; set; }  
 
		public DateTime UPDIDate { get; set; }  
 
		public String UPDIDescr { get; set; } 

        public void Validate()
        {
            new AddUserPlaningDetInfCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
