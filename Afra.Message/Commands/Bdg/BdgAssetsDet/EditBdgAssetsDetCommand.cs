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
    public class EditBdgAssetsDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BADParentRef { get; set; }  
 
		public Int32 BADMonth { get; set; }  
 
		public Nullable<Double> BADAstCost { get; set; }  
 
		public Nullable<Double> BADDepr { get; set; } 

        public void Validate()
        {
            new EditBdgAssetsDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
