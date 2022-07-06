using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class SMSSettingDto
    {
          
 
		public Int32 SMSSettingID { get; set; }  
 
		public Int32 SMSCompRef { get; set; }  
 
		public Nullable<Int32> SMSSetUserRef { get; set; }  
 
		public String SMSUserName { get; set; }  
 
		public String SMSUserPass { get; set; }  
 
		public String SMSLineNo { get; set; } 
    }
}


