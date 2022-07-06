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
    public class EditCntExpFldElmntsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntExpFldElmntId { get; set; }  
 
		public Int32 CEFEFldRef { get; set; }  
 
		public String CEFEValue { get; set; } 

        public void Validate()
        {
            new EditCntExpFldElmntsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
