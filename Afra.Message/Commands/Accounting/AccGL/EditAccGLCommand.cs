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
    public class EditAccGLCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public String gl_Code { get; set; }  
 
		public String PlRef { get; set; }  
 
		public String gl_Title { get; set; }  
 
		public String gl_BalanceType { get; set; } 

        public void Validate()
        {
            new EditAccGLCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
