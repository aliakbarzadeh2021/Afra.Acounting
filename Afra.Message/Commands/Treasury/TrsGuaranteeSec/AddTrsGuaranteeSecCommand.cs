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
    public class AddTrsGuaranteeSecCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsGuaranteeSecId { get; set; }  
 
		public Int32 TGSGuaRef { get; set; }  
 
		public String TGSDLRef { get; set; }  
 
		public String TGSFullName { get; set; }  
 
		public String TGSNatCode { get; set; }  
 
		public String TGSPhone { get; set; }  
 
		public String TGSMobile { get; set; }  
 
		public String TGSDescr { get; set; } 

        public void Validate()
        {
            new AddTrsGuaranteeSecCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
