using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class HrmIncDecVacDto
    {
          
 
		public Int32 HrmIncDecVacId { get; set; }  
 
		public Nullable<Int32> HIDVNum { get; set; }  
 
		public DateTime HIDVDate { get; set; }  
 
		public Nullable<Int32> HIDVPersRef { get; set; }  
 
		public Nullable<Int32> HIDVType { get; set; }  
 
		public DateTime HIDVTime { get; set; } 
    }
}


