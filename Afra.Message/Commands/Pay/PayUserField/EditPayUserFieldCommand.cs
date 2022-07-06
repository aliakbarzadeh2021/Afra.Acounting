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
    public class EditPayUserFieldCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayUserFieldId { get; set; }  
 
		public String PUFTitle { get; set; }  
 
		public String PUFForumula { get; set; } 

        public void Validate()
        {
            new EditPayUserFieldCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
