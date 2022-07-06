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
    public class AddWebDocsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 WebDocsId { get; set; }  
 
		public Int32 WDType { get; set; }  
 
		public String WDTitle { get; set; }  
 
		public String WDFileName { get; set; } 

        public void Validate()
        {
            new AddWebDocsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
