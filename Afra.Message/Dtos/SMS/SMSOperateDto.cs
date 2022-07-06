using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class SMSOperateDto
    {
          
 
		public Int32 SMSOperateId { get; set; }  
 
		public Int32 SMSMethodRef { get; set; }  
 
		public Nullable<Int32> SMSRole { get; set; }  
 
		public Nullable<Int32> SMSDur { get; set; }  
 
		public Nullable<Double> SMSDelay { get; set; }  
 
		public DateTime SMSStartDate { get; set; } 
    }
}


