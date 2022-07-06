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
    public class EditUsGroupsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 UsGroupId { get; set; }  
 
		public String UsGroupTitle { get; set; } 

        public void Validate()
        {
            new EditUsGroupsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
