using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class SleChngVchItmDto
    {
          
 
		public Int32 SleChngVchItmId { get; set; }  
 
		public Nullable<Int32> SleChngVchHdrRef { get; set; }  
 
		public Nullable<Int32> SCVISeq { get; set; }  
 
		public Int32 SCVIItmRef { get; set; }  
 
		public Nullable<Double> SCVIOldQty { get; set; }  
 
		public Nullable<Double> SCVIOldPrice { get; set; }  
 
		public Nullable<Double> SCVINewQty { get; set; }  
 
		public Nullable<Double> SCVINewPrice { get; set; }  
 
		public Nullable<Double> SCVIAmount { get; set; } 
    }
}


