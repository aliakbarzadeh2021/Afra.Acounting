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
    public class EditBdgElmntRolesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BdgElmntRoleId { get; set; }  
 
		public String BERTitle { get; set; } 

        public void Validate()
        {
            new EditBdgElmntRolesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
