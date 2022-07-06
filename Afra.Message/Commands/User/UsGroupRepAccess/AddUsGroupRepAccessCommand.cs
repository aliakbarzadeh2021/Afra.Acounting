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
    public class AddUsGroupRepAccessCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GroupRef { get; set; }  
 
		public Int32 ReportRef { get; set; }  
 
		public Nullable<Int32> Access { get; set; } 

        public void Validate()
        {
            new AddUsGroupRepAccessCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
