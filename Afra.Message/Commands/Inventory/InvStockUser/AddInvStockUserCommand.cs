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
    public class AddInvStockUserCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InvStockUserId { get; set; }  
 
		public Int32 ISUStockRef { get; set; }  
 
		public Int32 ISUUserRef { get; set; }  
 
		public Nullable<Int32> ISURight { get; set; } 

        public void Validate()
        {
            new AddInvStockUserCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
