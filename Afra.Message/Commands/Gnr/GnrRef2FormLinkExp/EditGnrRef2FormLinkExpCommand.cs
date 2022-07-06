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
    public class EditGnrRef2FormLinkExpCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 LinkRefHdrRef { get; set; }  
 
		public Int32 LRExItmId { get; set; } 

        public void Validate()
        {
            new EditGnrRef2FormLinkExpCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
