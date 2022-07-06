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
    public class AddUserSignRightCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 UserSignRightId { get; set; }  
 
		public Nullable<Int32> USRUserRef { get; set; }  
 
		public Nullable<Int32> USRToUser { get; set; }  
 
		public Nullable<Int32> USRAccess { get; set; } 

        public void Validate()
        {
            new AddUserSignRightCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
