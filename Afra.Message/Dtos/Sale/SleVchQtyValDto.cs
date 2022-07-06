using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class SleVchQtyValDto
    {
          
 
		public Int32 SleVchQtyValId { get; set; }  
 
		public Int32 SVQVchItmRef { get; set; }  
 
		public Nullable<Int32> SVQPrjRef { get; set; }  
 
		public String SVQDLRef { get; set; }  
 
		public Nullable<Int32> SVQProductRef { get; set; }  
 
		public String SVQOthVal { get; set; }  
 
		public String SVQOthDate { get; set; }  
 
		public Double SVQQty { get; set; } 
    }
}


