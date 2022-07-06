using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class InvVchTransDto
    {
          
 
		public Int32 InvVchTransId { get; set; }  
 
		public Nullable<Int32> InvVchItmRef { get; set; }  
 
		public String IVTNum { get; set; }  
 
		public DateTime IVTDater { get; set; }  
 
		public Nullable<Double> IVTQty { get; set; }  
 
		public String IVTDriver { get; set; }  
 
		public String IVTCarNo { get; set; }  
 
		public String IVTDescr { get; set; } 
    }
}


