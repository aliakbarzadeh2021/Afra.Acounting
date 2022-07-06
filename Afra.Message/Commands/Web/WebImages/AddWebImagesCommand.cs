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
    public class AddWebImagesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 WebImageId { get; set; }  
 
		public Int32 WIPersRef { get; set; }  
 
		public DateTime WIDate { get; set; }  
 
		public String WIType { get; set; }  
 
		public Byte[] WIData { get; set; } 

        public void Validate()
        {
            new AddWebImagesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
