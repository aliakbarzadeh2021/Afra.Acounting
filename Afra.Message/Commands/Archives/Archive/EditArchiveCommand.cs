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
    public class EditArchiveCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ArchiveId { get; set; }  
 
		public String AcTitle { get; set; }  
 
		public Nullable<Int32> AcTypeRef { get; set; }  
 
		public Nullable<Int32> TableItmId { get; set; }  
 
		public Nullable<Int32> FileKind { get; set; }  
 
		public Byte[] FileContent { get; set; }  
 
		public String FilePath { get; set; } 

        public void Validate()
        {
            new EditArchiveCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
