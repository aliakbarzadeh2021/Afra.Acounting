using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class SMSOperateDetDto
    {
          
 
		public Int32 SMSOperateDetId { get; set; }  
 
		public DateTime SMSOperateDate { get; set; }  
 
		public Int32 SMSOperateRef { get; set; }  
 
		public String SODNumber { get; set; }  
 
		public String SODDeliver { get; set; }  
 
		public String SODText { get; set; }  
 
		public DateTime SODSendDate { get; set; }  
 
		public DateTime SODRcvDate { get; set; }  
 
		public Nullable<Int32> SODSit { get; set; }  
 
		public String SODRefId { get; set; }  
 
		public String SODError { get; set; } 
    }
}


