using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CntGaurantInfDto
    {
          
 
		public Int32 CntGaurantInfId { get; set; }  
 
		public Int32 CGIBaseItm { get; set; }  
 
		public Int32 CGIBaseType { get; set; }  
 
		public DateTime CGIFromDate { get; set; }  
 
		public String CGIDur { get; set; }  
 
		public String CGIDescr { get; set; }  
 
		public Nullable<Double> CGIAmount { get; set; } 
    }
}


