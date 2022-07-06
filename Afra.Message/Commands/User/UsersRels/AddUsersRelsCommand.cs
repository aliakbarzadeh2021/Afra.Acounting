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
    public class AddUsersRelsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 MainUser { get; set; }  
 
		public Int32 RelUser { get; set; } 

        public void Validate()
        {
            new AddUsersRelsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
