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
    public class EditUsersCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 UserId { get; set; }  
 
		public String UserName { get; set; }  
 
		public String UserPass { get; set; }  
 
		public Nullable<Int32> UserGroupRef { get; set; }  
 
		public Byte[] UserSign { get; set; }  
 
		public Nullable<Int32> UserState { get; set; } 

        public void Validate()
        {
            new EditUsersCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
