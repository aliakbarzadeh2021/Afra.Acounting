using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PrdMachineDto
    {
          
 
		public Int32 PrdMachineId { get; set; }  
 
		public String PMTitle { get; set; }  
 
		public Int32 PMWorkStRef { get; set; }  
 
		public DateTime PMStartTime { get; set; }  
 
		public Nullable<Int32> PMDurHour { get; set; } 
    }
}


