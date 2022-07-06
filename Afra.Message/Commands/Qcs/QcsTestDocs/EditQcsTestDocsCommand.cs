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
    public class EditQcsTestDocsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 QTDTestRef { get; set; }  
 
		public Int32 QTDDocRef { get; set; } 

        public void Validate()
        {
            new EditQcsTestDocsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
