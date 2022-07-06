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
    public class EditOtoLttrDocCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 OtoLttrDocId { get; set; }  
 
		public Int32 OLDLttrRef { get; set; }  
 
		public Int32 OLDDocType { get; set; }  
 
		public Byte[] OLDContent { get; set; }  
 
		public String OLDExt { get; set; }  
 
		public Nullable<Int32> OLDTemplate { get; set; } 

        public void Validate()
        {
            new EditOtoLttrDocCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
