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
    public class EditCmrInvoiceCostCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CmrInvoiceCostId { get; set; }  
 
		public Int32 CICItmRef { get; set; }  
 
		public String CICDescr { get; set; }  
 
		public Double CICAmount { get; set; } 

        public void Validate()
        {
            new EditCmrInvoiceCostCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
