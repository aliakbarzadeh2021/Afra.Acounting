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
    public class AddUserAccessCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 UsrAccId { get; set; }  
 
		public Int32 UserRef { get; set; }  
 
		public String AccessName { get; set; }  
 
		public Int32 Rights { get; set; } 

        public void Validate()
        {
            new AddUserAccessCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
