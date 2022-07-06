using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SMSMethod : BaseEntity
    {
          
 
		public Int32 SMSMethodId { get; set; }  
 
		public String SMSMthdTitle { get; set; }  
 
		public Int32 SMSMthdType { get; set; }  
 
		public String SMSMthdSQL { get; set; }  
 
		public String SMSMthdText { get; set; } 
    }
}


