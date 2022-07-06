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
    public class AddAccDLCtgryCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AccDLCtgryId { get; set; }  
 
		public Nullable<Int32> ADCParentRef { get; set; }  
 
		public String ADCTitle { get; set; } 

        public void Validate()
        {
            new AddAccDLCtgryCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
