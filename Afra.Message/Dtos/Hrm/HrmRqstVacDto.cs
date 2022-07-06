using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class HrmRqstVacDto
    {
          
 
		public Int32 HrmRqstVacId { get; set; }  
 
		public Nullable<Int32> HRVVacRef { get; set; }  
 
		public Nullable<Int32> HRVNum { get; set; }  
 
		public DateTime HRVDate { get; set; }  
 
		public Nullable<Int32> HRVPersRef { get; set; }  
 
		public Nullable<Int32> HRVType { get; set; }  
 
		public DateTime HRVFromDate { get; set; }  
 
		public DateTime HRVFromTime { get; set; }  
 
		public DateTime HRVToDate { get; set; }  
 
		public DateTime HRVToTime { get; set; } 
    }
}


