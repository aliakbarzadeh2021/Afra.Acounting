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
    public class AddPayCompsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayCompID { get; set; }  
 
		public String PayCompName { get; set; }  
 
		public String PayCompType { get; set; } 

        public void Validate()
        {
            new AddPayCompsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
