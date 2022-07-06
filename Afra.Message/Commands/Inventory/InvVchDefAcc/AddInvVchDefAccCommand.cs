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
    public class AddInvVchDefAccCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InvVchDefAccId { get; set; }  
 
		public Int32 IVDAAccPrd { get; set; }  
 
		public Int32 IVDAVchType { get; set; }  
 
		public Nullable<Int32> IVDAPartRef { get; set; }  
 
		public String IVDADLRef { get; set; }  
 
		public String IVDASLRef { get; set; } 

        public void Validate()
        {
            new AddInvVchDefAccCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
