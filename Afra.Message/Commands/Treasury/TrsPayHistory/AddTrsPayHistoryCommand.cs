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
    public class AddTrsPayHistoryCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsPayHistoryId { get; set; }  
 
		public Int32 TPHItmRef { get; set; }  
 
		public DateTime TPHItmDate { get; set; }  
 
		public String TPHItmState { get; set; }  
 
		public Nullable<Int32> TPHOprId { get; set; }  
 
		public Nullable<Int32> TPHTrsOpr { get; set; } 

        public void Validate()
        {
            new AddTrsPayHistoryCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
