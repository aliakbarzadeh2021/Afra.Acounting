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
    public class EditPayVchTypeCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayVchTypeId { get; set; }  
 
		public String PVTTitle { get; set; }  
 
		public Nullable<Int32> PVTType { get; set; } 

        public void Validate()
        {
            new EditPayVchTypeCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
