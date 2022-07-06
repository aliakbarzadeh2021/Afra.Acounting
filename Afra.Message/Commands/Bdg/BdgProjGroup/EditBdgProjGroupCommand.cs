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
    public class EditBdgProjGroupCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BdgProjGroupId { get; set; }  
 
		public String BPGTitle { get; set; } 

        public void Validate()
        {
            new EditBdgProjGroupCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
