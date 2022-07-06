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
    public class EditGnrLimitUserCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GnrLimitUserId { get; set; }  
 
		public Int32 GLUGroupRef { get; set; }  
 
		public Int32 GLUUserRef { get; set; }  
 
		public Int32 GLUObjRef { get; set; }  
 
		public Nullable<Int32> GLUAccess { get; set; } 

        public void Validate()
        {
            new EditGnrLimitUserCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
