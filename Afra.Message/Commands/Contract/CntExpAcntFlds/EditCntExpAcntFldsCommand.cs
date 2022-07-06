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
    public class EditCntExpAcntFldsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntExpAcnFldId { get; set; }  
 
		public String CEAFTitle { get; set; }  
 
		public Int32 CEAType { get; set; }  
 
		public Nullable<Int32> CEAPrvty { get; set; } 

        public void Validate()
        {
            new EditCntExpAcntFldsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
