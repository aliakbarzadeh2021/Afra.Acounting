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
    public class EditHrmPersMrgCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PersMrgId { get; set; }  
 
		public Nullable<Int32> PMgPersRef { get; set; }  
 
		public Nullable<Int32> PersMrgSit { get; set; }  
 
		public DateTime PersMrgDate { get; set; } 

        public void Validate()
        {
            new EditHrmPersMrgCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
