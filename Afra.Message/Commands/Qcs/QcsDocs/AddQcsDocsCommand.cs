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
    public class AddQcsDocsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 QcsDocId { get; set; }  
 
		public String QDCode { get; set; }  
 
		public String QDTitle { get; set; }  
 
		public String QDFileExt { get; set; }  
 
		public Byte[] QDImage { get; set; } 

        public void Validate()
        {
            new AddQcsDocsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
