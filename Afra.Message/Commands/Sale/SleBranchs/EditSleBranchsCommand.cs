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
    public class EditSleBranchsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SleBranchId { get; set; }  
 
		public String SleBranchCode { get; set; }  
 
		public String SleBranchName { get; set; }  
 
		public String SleBranchDLRef { get; set; } 

        public void Validate()
        {
            new EditSleBranchsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
