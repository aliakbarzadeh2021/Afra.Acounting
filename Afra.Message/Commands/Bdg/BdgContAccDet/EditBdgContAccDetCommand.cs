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
    public class EditBdgContAccDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BCADParentRef { get; set; }  
 
		public Int32 BCADMonth { get; set; }  
 
		public Double BCADAmount { get; set; } 

        public void Validate()
        {
            new EditBdgContAccDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
