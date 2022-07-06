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
    public class EditBdgProjDetInfCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BPDIParentRef { get; set; }  
 
		public Int32 BPDIMonth { get; set; }  
 
		public Nullable<Double> BPDIAmount { get; set; } 

        public void Validate()
        {
            new EditBdgProjDetInfCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
