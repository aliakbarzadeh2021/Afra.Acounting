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
    public class AddCstElmntRolesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CstElmntRoleId { get; set; }  
 
		public String CERTitle { get; set; } 

        public void Validate()
        {
            new AddCstElmntRolesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
