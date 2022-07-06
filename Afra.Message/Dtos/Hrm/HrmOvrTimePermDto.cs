using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class HrmOvrTimePermDto
    {
          
 
		public Int32 HrmOvrTimePermId { get; set; }  
 
		public Nullable<Int32> HOvPPersRef { get; set; }  
 
		public Nullable<Int32> HOvPNum { get; set; }  
 
		public DateTime HOvPDate { get; set; }  
 
		public DateTime HOvPFromDate { get; set; }  
 
		public DateTime HOvPFromTime { get; set; }  
 
		public DateTime HOvPToDate { get; set; }  
 
		public DateTime HOvPToTime { get; set; } 
    }
}


