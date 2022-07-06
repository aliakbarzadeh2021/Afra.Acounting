using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class GnrUserMsgDto
    {
          
 
		public Int32 GnrUserMsgId { get; set; }  
 
		public Int32 GUMFromUser { get; set; }  
 
		public Int32 GUMToUser { get; set; }  
 
		public String GUMMsg { get; set; }  
 
		public Nullable<Int32> GUMSit { get; set; }  
 
		public Nullable<Int32> GUMAlarmRef { get; set; }  
 
		public DateTime GUMDate { get; set; } 
    }
}


