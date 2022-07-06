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
    public class AddTrsSourceUseRelsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TSURMaster { get; set; }  
 
		public Int32 TSURChild { get; set; } 

        public void Validate()
        {
            new AddTrsSourceUseRelsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
