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
    public class EditOtoBaseTypeValsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 OtoBaseTypeValsId { get; set; }  
 
		public Int32 OtoBaseTypeRef { get; set; }  
 
		public String OBTValue { get; set; } 

        public void Validate()
        {
            new EditOtoBaseTypeValsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
