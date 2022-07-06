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
    public class EditCntGnrTextCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntGnrTextId { get; set; }  
 
		public Int32 CGTType { get; set; }  
 
		public String CGTContain { get; set; } 

        public void Validate()
        {
            new EditCntGnrTextCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
