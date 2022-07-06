using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class WebMessages : BaseEntity
    {
          
 
		public Int32 WebMsgId { get; set; }  
 
		public String WMNatCode { get; set; }  
 
		public DateTime WMSndDate { get; set; }  
 
		public DateTime WMRcvDate { get; set; }  
 
		public String WMTitle { get; set; }  
 
		public String WMMsg { get; set; } 
    }
}


