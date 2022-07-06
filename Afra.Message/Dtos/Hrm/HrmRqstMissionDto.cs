using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class HrmRqstMissionDto
    {
          
 
		public Int32 HrmRqstMissionId { get; set; }  
 
		public Nullable<Int32> HRMMissionRef { get; set; }  
 
		public Nullable<Int32> HRMNum { get; set; }  
 
		public DateTime HRMDate { get; set; }  
 
		public Nullable<Int32> HRMPersRef { get; set; }  
 
		public Nullable<Int32> HRMType { get; set; }  
 
		public DateTime HRMFromDate { get; set; }  
 
		public DateTime HRMFromTime { get; set; }  
 
		public DateTime HRMToDate { get; set; }  
 
		public DateTime HRMToTime { get; set; }  
 
		public Nullable<Int32> HRMCityRef { get; set; } 
    }
}


