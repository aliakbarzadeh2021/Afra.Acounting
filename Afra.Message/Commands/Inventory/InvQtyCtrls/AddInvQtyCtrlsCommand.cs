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
    public class AddInvQtyCtrlsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InvQtyCtrlId { get; set; }  
 
		public String IQCTitle { get; set; }  
 
		public String IQCBaseType { get; set; }  
 
		public String IQCValType { get; set; }  
 
		public String ICQValRole { get; set; } 

        public void Validate()
        {
            new AddInvQtyCtrlsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
