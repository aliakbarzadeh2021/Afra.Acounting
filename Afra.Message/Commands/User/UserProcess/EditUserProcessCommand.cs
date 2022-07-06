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
    public class EditUserProcessCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 UserProcessId { get; set; }  
 
		public Int32 UPProcessRef { get; set; }  
 
		public DateTime UPCrDate { get; set; }  
 
		public Int32 UPUserRef { get; set; } 

        public void Validate()
        {
            new EditUserProcessCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
