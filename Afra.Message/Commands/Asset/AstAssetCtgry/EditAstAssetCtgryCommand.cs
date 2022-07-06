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
    public class EditAstAssetCtgryCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AstAssetCtgryId { get; set; }  
 
		public String AACCode { get; set; }  
 
		public String AACName { get; set; } 

        public void Validate()
        {
            new EditAstAssetCtgryCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
