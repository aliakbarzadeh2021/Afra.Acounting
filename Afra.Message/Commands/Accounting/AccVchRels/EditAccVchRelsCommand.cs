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
    public class EditAccVchRelsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 RelAccHdrRef { get; set; }  
 
		public Int32 RelBaseItmRef { get; set; }  
 
		public String RelBaseType { get; set; }  
 
		public Int32 RelAccItmRef { get; set; } 

        public void Validate()
        {
            new EditAccVchRelsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
