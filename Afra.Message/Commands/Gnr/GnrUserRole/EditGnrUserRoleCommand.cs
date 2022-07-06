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
    public class EditGnrUserRoleCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Nullable<Int32> GURUserRef { get; set; }  
 
		public Int32 GURRoleRef { get; set; } 

        public void Validate()
        {
            new EditGnrUserRoleCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
