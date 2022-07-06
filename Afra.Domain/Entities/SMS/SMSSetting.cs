using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SMSSetting : BaseEntity
    {
          
 
		public Int32 SMSSettingID { get; set; }  
 
		public Int32 SMSCompRef { get; set; }  
 
		public Nullable<Int32> SMSSetUserRef { get; set; }  
 
		public String SMSUserName { get; set; }  
 
		public String SMSUserPass { get; set; }  
 
		public String SMSLineNo { get; set; } 
    }
}


