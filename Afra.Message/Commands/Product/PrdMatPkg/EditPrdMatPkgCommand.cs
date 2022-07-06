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
    public class EditPrdMatPkgCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PMPMatRef { get; set; }  
 
		public Nullable<Double> PMPPkgQty { get; set; } 

        public void Validate()
        {
            new EditPrdMatPkgCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
