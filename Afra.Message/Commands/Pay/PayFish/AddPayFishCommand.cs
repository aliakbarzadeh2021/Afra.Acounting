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
    public class AddPayFishCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayFishId { get; set; }  
 
		public String PFTitle { get; set; }  
 
		public String PFFileName { get; set; } 

        public void Validate()
        {
            new AddPayFishCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
