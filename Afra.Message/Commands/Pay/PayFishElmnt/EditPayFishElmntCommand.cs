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
    public class EditPayFishElmntCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PFEHdrRef { get; set; }  
 
		public Int32 PFEElmntRef { get; set; } 

        public void Validate()
        {
            new EditPayFishElmntCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
