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
    public class EditUserArchTypeCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 UserArchTypeId { get; set; }  
 
		public Int32 UATUsrRef { get; set; }  
 
		public String UATTitle { get; set; }  
 
		public Nullable<Int32> UATParent { get; set; } 

        public void Validate()
        {
            new EditUserArchTypeCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
