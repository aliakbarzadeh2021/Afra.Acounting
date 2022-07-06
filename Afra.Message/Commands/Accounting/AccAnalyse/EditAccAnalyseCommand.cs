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
    public class EditAccAnalyseCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 DebitVchItmRef { get; set; }  
 
		public Int32 CreditVchItmRef { get; set; }  
 
		public Nullable<Int32> AccLevel { get; set; }  
 
		public Nullable<Int32> State { get; set; } 

        public void Validate()
        {
            new EditAccAnalyseCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
