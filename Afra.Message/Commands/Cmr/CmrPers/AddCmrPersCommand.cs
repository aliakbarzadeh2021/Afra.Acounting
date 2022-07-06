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
    public class AddCmrPersCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CmrPersId { get; set; }  
 
		public Int32 CPCrspndRef { get; set; }  
 
		public Nullable<Int32> CPType { get; set; } 

        public void Validate()
        {
            new AddCmrPersCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
