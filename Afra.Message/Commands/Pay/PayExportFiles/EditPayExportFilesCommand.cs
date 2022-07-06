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
    public class EditPayExportFilesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayExpFileId { get; set; }  
 
		public String PEFTitle { get; set; }  
 
		public String PEFName { get; set; }  
 
		public String PEFDelimt { get; set; }  
 
		public Nullable<Int32> PEFFixName { get; set; }  
 
		public String PEFDefPath { get; set; }  
 
		public Nullable<Int32> PEFBankRef { get; set; } 

        public void Validate()
        {
            new EditPayExportFilesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
