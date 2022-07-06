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
    public class AddUsGroupsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 UsGroupId { get; set; }  
 
		public String UsGroupTitle { get; set; } 

        public void Validate()
        {
            new AddUsGroupsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
