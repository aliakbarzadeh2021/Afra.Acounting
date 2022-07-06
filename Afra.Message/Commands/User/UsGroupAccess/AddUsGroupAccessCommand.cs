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
    public class AddUsGroupAccessCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 UsGrpAccId { get; set; }  
 
		public Int32 GroupRef { get; set; }  
 
		public String AccessName { get; set; }  
 
		public Int32 Rights { get; set; } 

        public void Validate()
        {
            new AddUsGroupAccessCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
