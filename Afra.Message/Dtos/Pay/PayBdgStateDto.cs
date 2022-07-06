using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PayBdgStateDto
    {
          
 
		public Int32 PayBdgStateId { get; set; }  
 
		public Int32 PBSPersRef { get; set; }  
 
		public Int32 PBSYearNum { get; set; }  
 
		public Int32 PBSMonthNum { get; set; }  
 
		public Nullable<Int32> PBSCalcType { get; set; }  
 
		public Nullable<Int32> PBSYearMonth { get; set; } 
    }
}


