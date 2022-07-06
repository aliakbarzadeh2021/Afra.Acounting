using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PayCalcBaseDto
    {
          
 
		public Int32 PayCalcBaseId { get; set; }  
 
		public Nullable<Int32> PCBType { get; set; }  
 
		public Nullable<Int32> PCBPersRef { get; set; }  
 
		public Nullable<Int32> PCBElmntRef { get; set; }  
 
		public Nullable<Int32> PCBYearNum { get; set; }  
 
		public Nullable<Int32> PCBMonthNum { get; set; }  
 
		public Nullable<Int32> PCBVal { get; set; }  
 
		public Nullable<Int32> PCBYearMonth { get; set; } 
    }
}


