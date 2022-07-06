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
    public class AddCmrReleaseStockCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CmrReleaseStockId { get; set; }  
 
		public Int32 CRSItmRef { get; set; }  
 
		public String CRSNum { get; set; }  
 
		public DateTime CRSDate { get; set; }  
 
		public String CRSDescr { get; set; } 

        public void Validate()
        {
            new AddCmrReleaseStockCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
