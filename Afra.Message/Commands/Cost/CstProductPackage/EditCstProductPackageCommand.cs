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
    public class EditCstProductPackageCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CstProductPackageId { get; set; }  
 
		public Nullable<Int32> CPPProductRef { get; set; }  
 
		public String CPPTitle { get; set; }  
 
		public DateTime CPPDate { get; set; }  
 
		public Nullable<Int32> CPPPeriodId { get; set; } 

        public void Validate()
        {
            new EditCstProductPackageCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
