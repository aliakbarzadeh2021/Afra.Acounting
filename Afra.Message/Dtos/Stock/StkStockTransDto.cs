using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class StkStockTransDto
    {
          
 
		public Int32 StkStockTranId { get; set; }  
 
		public String SSTNum { get; set; }  
 
		public DateTime SSTDate { get; set; }  
 
		public Int32 SSTType { get; set; }  
 
		public Int32 SSTSStockerRef { get; set; }  
 
		public Int32 SSTRStockerRef { get; set; }  
 
		public Double SSTQty { get; set; }  
 
		public Nullable<Double> SSTRate { get; set; }  
 
		public Int32 SSTPeriodRef { get; set; } 
    }
}


