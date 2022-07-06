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
    public class AddPayImportFilesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayImpFileId { get; set; }  
 
		public String PIFTitle { get; set; }  
 
		public Nullable<Int32> PIFFormat { get; set; }  
 
		public String PIFPCFldName { get; set; }  
 
		public Nullable<Int32> PIFPCStart { get; set; }  
 
		public Nullable<Int32> PIFPCCnt { get; set; } 

        public void Validate()
        {
            new AddPayImportFilesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
