using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PayBuyBaseDto
    {
          
 
		public Int32 PayBuyBaseId { get; set; }  
 
		public Int32 PBBPersRef { get; set; }  
 
		public Int32 PBBYearNum { get; set; }  
 
		public Int32 PBBMonthNum { get; set; }  
 
		public DateTime PBBInstDate { get; set; }  
 
		public Nullable<Int32> PBBFirstWorkDay { get; set; }  
 
		public Nullable<Int32> PBBFirstAllDay { get; set; }  
 
		public Nullable<Int32> PBBFirstWorkLess { get; set; }  
 
		public Nullable<Double> PBBFirstBuyVal { get; set; }  
 
		public Nullable<Int32> PBBYearMonth { get; set; } 
    }
}


