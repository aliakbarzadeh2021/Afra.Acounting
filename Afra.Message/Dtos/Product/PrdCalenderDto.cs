using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PrdCalenderDto
    {
          
 
		public Int32 PrdCalenderId { get; set; }  
 
		public DateTime PCDate { get; set; }  
 
		public Int32 PCDayType { get; set; }  
 
		public DateTime PCPrdSTime { get; set; }  
 
		public DateTime PCPrdETime { get; set; } 
    }
}


