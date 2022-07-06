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
    public class AddUserProcessCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 UserProcessId { get; set; }  
 
		public Int32 UPProcessRef { get; set; }  
 
		public DateTime UPCrDate { get; set; }  
 
		public Int32 UPUserRef { get; set; } 

        public void Validate()
        {
            new AddUserProcessCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
