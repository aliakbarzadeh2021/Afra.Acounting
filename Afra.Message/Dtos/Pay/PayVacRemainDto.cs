using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PayVacRemainDto
    {
          
 
		public Int32 PayVacRemainId { get; set; }  
 
		public Nullable<Int32> PVRPersRef { get; set; }  
 
		public Nullable<Int32> PVRVacRef { get; set; }  
 
		public Nullable<Int32> PVRYear { get; set; }  
 
		public Nullable<Int32> PVRMonth { get; set; }  
 
		public Nullable<Int32> PVRDay { get; set; }  
 
		public Nullable<Int32> PVRHour { get; set; }  
 
		public Nullable<Int32> PVRMinute { get; set; }  
 
		public Nullable<Int32> PVRYearMonth { get; set; } 
    }
}


