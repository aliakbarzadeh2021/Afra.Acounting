using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CmrPOrderItmDto
    {
          
 
		public Int32 CmrPOrderItmId { get; set; }  
 
		public Int32 CPOISeq { get; set; }  
 
		public Int32 CmrPOrderHdrRef { get; set; }  
 
		public Int32 CPOIItmType { get; set; }  
 
		public Int32 CPOIItmRef { get; set; }  
 
		public Nullable<Double> CPOIOthQty { get; set; }  
 
		public Nullable<Double> CPOIMainQty { get; set; }  
 
		public String CPOIDescr { get; set; }  
 
		public Nullable<Int32> CPOIStatus { get; set; } 
    }
}


