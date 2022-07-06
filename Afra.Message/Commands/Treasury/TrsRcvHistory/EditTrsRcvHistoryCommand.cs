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
    public class EditTrsRcvHistoryCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsRcvHistoryId { get; set; }  
 
		public Int32 TRHItmRef { get; set; }  
 
		public DateTime TRHItmDate { get; set; }  
 
		public String TRHItmState { get; set; }  
 
		public Nullable<Int32> TRHOprId { get; set; }  
 
		public Nullable<Int32> TRHTrsOpr { get; set; } 

        public void Validate()
        {
            new EditTrsRcvHistoryCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
