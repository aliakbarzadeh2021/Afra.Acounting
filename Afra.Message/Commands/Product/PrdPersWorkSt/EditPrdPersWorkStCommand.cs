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
    public class EditPrdPersWorkStCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PPWPersRef { get; set; }  
 
		public Int32 PPWWorkStRef { get; set; } 

        public void Validate()
        {
            new EditPrdPersWorkStCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
