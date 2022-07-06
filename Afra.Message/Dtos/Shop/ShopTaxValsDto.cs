using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class ShopTaxValsDto
    {
          
 
		public Int32 ShopTaxValsId { get; set; }  
 
		public Int32 STVTaxRef { get; set; }  
 
		public DateTime STVDate { get; set; }  
 
		public Nullable<Int32> STVPartRef { get; set; }  
 
		public String STVDescr { get; set; }  
 
		public Nullable<Double> STVAmount { get; set; } 
    }
}


