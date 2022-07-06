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
    public class EditGnrFormRepRelsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 FormRepRelId { get; set; }  
 
		public String FRRFormId { get; set; }  
 
		public Nullable<Int32> FRRepRef { get; set; } 

        public void Validate()
        {
            new EditGnrFormRepRelsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
