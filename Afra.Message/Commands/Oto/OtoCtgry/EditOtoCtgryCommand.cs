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
    public class EditOtoCtgryCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 OtoCtgryId { get; set; }  
 
		public Nullable<Int32> OCParent { get; set; }  
 
		public String OCTitle { get; set; } 

        public void Validate()
        {
            new EditOtoCtgryCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
