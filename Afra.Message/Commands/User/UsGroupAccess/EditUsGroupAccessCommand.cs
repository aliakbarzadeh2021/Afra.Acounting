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
    public class EditUsGroupAccessCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 UsGrpAccId { get; set; }  
 
		public Int32 GroupRef { get; set; }  
 
		public String AccessName { get; set; }  
 
		public Int32 Rights { get; set; } 

        public void Validate()
        {
            new EditUsGroupAccessCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
