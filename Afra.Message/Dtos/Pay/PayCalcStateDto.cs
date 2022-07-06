using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PayCalcStateDto
    {
          
 
		public Int32 PayCalcStateId { get; set; }  
 
		public Int32 PCSPersRef { get; set; }  
 
		public Int32 PCSYearNum { get; set; }  
 
		public Int32 PCSMonthNum { get; set; }  
 
		public Nullable<Int32> PCSCalcType { get; set; }  
 
		public Nullable<Int32> PCSYearMonth { get; set; }  
 
		public Nullable<Int32> PCSUserRef { get; set; }  
 
		public Nullable<Int32> PCSOrgType { get; set; } 
    }
}


