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
    public class AddCntCMthdFldsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntCMthdFldId { get; set; }  
 
		public Int32 CCMFldRef { get; set; }  
 
		public String CCMFDescr { get; set; }  
 
		public String CCMFormula { get; set; }  
 
		public String CCMFormulDescr { get; set; } 

        public void Validate()
        {
            new AddCntCMthdFldsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
