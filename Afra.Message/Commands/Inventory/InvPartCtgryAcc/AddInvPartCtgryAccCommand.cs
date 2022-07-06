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
    public class AddInvPartCtgryAccCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InvPartCtgryAccId { get; set; }  
 
		public Nullable<Int32> IPCACtgryRef { get; set; }  
 
		public String IPCAType { get; set; }  
 
		public String IPCASLRef { get; set; } 

        public void Validate()
        {
            new AddInvPartCtgryAccCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
