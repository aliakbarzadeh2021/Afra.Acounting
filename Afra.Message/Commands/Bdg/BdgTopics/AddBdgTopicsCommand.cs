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
    public class AddBdgTopicsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BdgTopicsId { get; set; }  
 
		public String BTTitle { get; set; }  
 
		public Nullable<Int32> BTPriority { get; set; } 

        public void Validate()
        {
            new AddBdgTopicsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
