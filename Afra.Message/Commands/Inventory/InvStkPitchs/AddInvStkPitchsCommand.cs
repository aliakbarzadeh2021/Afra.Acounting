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
    public class AddInvStkPitchsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InvStkPitchId { get; set; }  
 
		public Nullable<Int32> ISPParent { get; set; }  
 
		public String ISPCode { get; set; }  
 
		public String ISPTitle { get; set; } 

        public void Validate()
        {
            new AddInvStkPitchsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
