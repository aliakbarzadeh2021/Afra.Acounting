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
    public class EditOtoAttachCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 OtoAttachId { get; set; }  
 
		public Int32 OARefType { get; set; }  
 
		public Int32 OARefId { get; set; }  
 
		public Int32 OAType { get; set; }  
 
		public Nullable<Int32> OABaseId { get; set; }  
 
		public String OADescr { get; set; }  
 
		public Byte[] OAFileContent { get; set; }  
 
		public String OAFileExt { get; set; } 

        public void Validate()
        {
            new EditOtoAttachCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
