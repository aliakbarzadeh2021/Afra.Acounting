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
    public class AddElmntMethodRolesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 EMRMthdRef { get; set; }  
 
		public Int32 EMRRoleRef { get; set; } 

        public void Validate()
        {
            new AddElmntMethodRolesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
