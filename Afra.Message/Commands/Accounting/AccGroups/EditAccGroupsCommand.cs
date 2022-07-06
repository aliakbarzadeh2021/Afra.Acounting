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
    public class EditAccGroupsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AccGroupsId { get; set; }  
 
		public String AGTitle { get; set; } 

        public void Validate()
        {
            new EditAccGroupsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
