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
    public class EditCntAmntTypesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntAmntTypeId { get; set; }  
 
		public String CATTitle { get; set; }  
 
		public String CATFormula { get; set; } 

        public void Validate()
        {
            new EditCntAmntTypesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
