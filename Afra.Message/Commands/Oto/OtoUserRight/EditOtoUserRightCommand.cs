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
    public class EditOtoUserRightCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 OtoUserRightId { get; set; }  
 
		public Int32 OURUserRef { get; set; }  
 
		public Int32 OURRelType { get; set; }  
 
		public Int32 OURRelId { get; set; }  
 
		public Int32 OURObjType { get; set; }  
 
		public Int32 OURAccess { get; set; } 

        public void Validate()
        {
            new EditOtoUserRightCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
