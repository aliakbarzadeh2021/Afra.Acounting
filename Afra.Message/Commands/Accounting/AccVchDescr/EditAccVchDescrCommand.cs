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
    public class EditAccVchDescrCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AccVchDescrId { get; set; }  
 
		public String AVDType { get; set; }  
 
		public String AVDDebitD { get; set; }  
 
		public String AVDCreditD { get; set; } 

        public void Validate()
        {
            new EditAccVchDescrCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
