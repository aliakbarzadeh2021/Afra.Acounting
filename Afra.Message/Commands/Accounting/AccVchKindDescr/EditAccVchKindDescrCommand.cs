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
    public class EditAccVchKindDescrCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AccVchKindDescrId { get; set; }  
 
		public String AVKDSysRef { get; set; }  
 
		public String AVKDType { get; set; }  
 
		public String AVKDDebitD { get; set; }  
 
		public String AVKDCreditD { get; set; } 

        public void Validate()
        {
            new EditAccVchKindDescrCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
