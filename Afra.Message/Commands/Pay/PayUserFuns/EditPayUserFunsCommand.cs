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
    public class EditPayUserFunsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayUserFuncId { get; set; }  
 
		public String PUFTitle { get; set; }  
 
		public String PUFName { get; set; } 

        public void Validate()
        {
            new EditPayUserFunsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
