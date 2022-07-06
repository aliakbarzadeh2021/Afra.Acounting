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
    public class EditGnrUserLabelsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GnrUserLabelId { get; set; }  
 
		public Int32 GULUserRef { get; set; }  
 
		public String GULTitle { get; set; }  
 
		public Nullable<Int32> GULParent { get; set; } 

        public void Validate()
        {
            new EditGnrUserLabelsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
