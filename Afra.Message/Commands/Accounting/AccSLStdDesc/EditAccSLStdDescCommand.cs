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
    public class EditAccSLStdDescCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 stdesc_id { get; set; }  
 
		public String stdesc_Slref { get; set; }  
 
		public String stdesc_str { get; set; } 

        public void Validate()
        {
            new EditAccSLStdDescCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
