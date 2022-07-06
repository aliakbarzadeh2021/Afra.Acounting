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
    public class AddOtoTemplatesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 OtoTemplateId { get; set; }  
 
		public String OTTitle { get; set; }  
 
		public Int32 OTDocType { get; set; }  
 
		public Byte[] OTContent { get; set; } 

        public void Validate()
        {
            new AddOtoTemplatesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
