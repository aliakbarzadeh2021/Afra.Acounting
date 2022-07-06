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
    public class AddStkStockDocsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 StkStockDocId { get; set; }  
 
		public Int32 SSDStockerRef { get; set; }  
 
		public Int32 SSDType { get; set; }  
 
		public Int32 SSDNum { get; set; }  
 
		public Double SSDQty { get; set; }  
 
		public Int32 SSDState { get; set; }  
 
		public Int32 SSDPeriodRef { get; set; } 

        public void Validate()
        {
            new AddStkStockDocsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
