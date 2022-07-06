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
    public class EditCmrReleaseStockCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CmrReleaseStockId { get; set; }  
 
		public Int32 CRSItmRef { get; set; }  
 
		public String CRSNum { get; set; }  
 
		public DateTime CRSDate { get; set; }  
 
		public String CRSDescr { get; set; } 

        public void Validate()
        {
            new EditCmrReleaseStockCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
