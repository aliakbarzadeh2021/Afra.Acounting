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
    public class AddBdgHrmValsDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BHVDParentRef { get; set; }  
 
		public Int32 BHVDMonth { get; set; }  
 
		public Double BHVDAmount { get; set; } 

        public void Validate()
        {
            new AddBdgHrmValsDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
