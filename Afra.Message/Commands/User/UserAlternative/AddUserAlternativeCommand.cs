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
    public class AddUserAlternativeCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 MainUserRef { get; set; }  
 
		public Int32 AlterUserRef { get; set; }  
 
		public Nullable<Int32> OrderInd { get; set; } 

        public void Validate()
        {
            new AddUserAlternativeCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
