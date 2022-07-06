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
    public class EditQcsMenLabsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 QMLMenRef { get; set; }  
 
		public Int32 QMLLabRef { get; set; } 

        public void Validate()
        {
            new EditQcsMenLabsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
