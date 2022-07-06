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
    public class AddGnrProcessDetUsersCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GPDUHdrRef { get; set; }  
 
		public Int32 GPDUUsrRef { get; set; }  
 
		public Nullable<Int32> GPDUInd { get; set; }  
 
		public Nullable<Int32> GPDUAnsDur { get; set; }  
 
		public Nullable<Int32> GPDUPersuitUser { get; set; } 

        public void Validate()
        {
            new AddGnrProcessDetUsersCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
