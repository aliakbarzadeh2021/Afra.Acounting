using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class WebMessagesDto
    {
          
 
		public Int32 WebMsgId { get; set; }  
 
		public String WMNatCode { get; set; }  
 
		public DateTime WMSndDate { get; set; }  
 
		public DateTime WMRcvDate { get; set; }  
 
		public String WMTitle { get; set; }  
 
		public String WMMsg { get; set; } 
    }
}


