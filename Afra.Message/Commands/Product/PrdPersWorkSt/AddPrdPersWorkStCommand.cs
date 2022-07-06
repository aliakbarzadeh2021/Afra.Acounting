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
    public class AddPrdPersWorkStCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PPWPersRef { get; set; }  
 
		public Int32 PPWWorkStRef { get; set; } 

        public void Validate()
        {
            new AddPrdPersWorkStCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
