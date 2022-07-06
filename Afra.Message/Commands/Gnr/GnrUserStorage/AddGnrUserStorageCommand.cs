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
    public class AddGnrUserStorageCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public String GUSFormRef { get; set; }  
 
		public Int32 GUSUserRef { get; set; }  
 
		public Int32 GUSType { get; set; }  
 
		public String GUSValue { get; set; } 

        public void Validate()
        {
            new AddGnrUserStorageCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
