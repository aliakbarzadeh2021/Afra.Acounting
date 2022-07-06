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
    public class AddUsrPersHrmRelsKigrCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Nullable<Int32> ParentId { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> State { get; set; }  
 
		public String MonthYear { get; set; }  
 
		public Nullable<Int32> Amount { get; set; } 

        public void Validate()
        {
            new AddUsrPersHrmRelsKigrCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
