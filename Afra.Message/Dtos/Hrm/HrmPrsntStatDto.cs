using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class HrmPrsntStatDto
    {
          
 
		public Int32 HrmPrsntStatId { get; set; }  
 
		public Nullable<Int32> HPSType { get; set; }  
 
		public Nullable<Int32> HPSNum { get; set; }  
 
		public DateTime HPSDate { get; set; }  
 
		public Nullable<Int32> HPSPersRef { get; set; }  
 
		public DateTime HPSFromDate { get; set; }  
 
		public DateTime HPSToDate { get; set; } 
    }
}


