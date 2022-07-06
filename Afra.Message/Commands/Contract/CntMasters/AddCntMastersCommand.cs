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
    public class AddCntMastersCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntMasterId { get; set; }  
 
		public Int32 CMCrsRef { get; set; }  
 
		public String CMSLRef { get; set; } 

        public void Validate()
        {
            new AddCntMastersCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
