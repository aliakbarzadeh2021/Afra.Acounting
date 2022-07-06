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
    public class AddStkStockTransCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 StkStockTranId { get; set; }  
 
		public String SSTNum { get; set; }  
 
		public DateTime SSTDate { get; set; }  
 
		public Int32 SSTType { get; set; }  
 
		public Int32 SSTSStockerRef { get; set; }  
 
		public Int32 SSTRStockerRef { get; set; }  
 
		public Double SSTQty { get; set; }  
 
		public Nullable<Double> SSTRate { get; set; }  
 
		public Int32 SSTPeriodRef { get; set; } 

        public void Validate()
        {
            new AddStkStockTransCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
