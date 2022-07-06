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
    public class EditPayRepListsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayRepListId { get; set; }  
 
		public String PRLTitle { get; set; }  
 
		public String PRLFileName { get; set; } 

        public void Validate()
        {
            new EditPayRepListsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
