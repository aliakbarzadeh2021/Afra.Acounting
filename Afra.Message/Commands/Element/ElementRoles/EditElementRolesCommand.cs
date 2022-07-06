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
    public class EditElementRolesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ElementRoleId { get; set; }  
 
		public String ERTitle { get; set; } 

        public void Validate()
        {
            new EditElementRolesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
