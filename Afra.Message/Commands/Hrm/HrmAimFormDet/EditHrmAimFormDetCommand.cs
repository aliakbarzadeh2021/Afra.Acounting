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
    public class EditHrmAimFormDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HAFDFormRef { get; set; }  
 
		public Int32 HAFDElmntRef { get; set; }  
 
		public Nullable<Double> HAFDRatio { get; set; } 

        public void Validate()
        {
            new EditHrmAimFormDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
