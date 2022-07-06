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
    public class AddPrdPersCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PrdPersId { get; set; }  
 
		public Int32 PPPersRef { get; set; }  
 
		public Int32 PPAlowProg { get; set; } 

        public void Validate()
        {
            new AddPrdPersCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
