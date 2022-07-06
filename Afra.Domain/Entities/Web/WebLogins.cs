using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class WebLogins : BaseEntity
    {
          
 
		public Int32 WebLoginId { get; set; }  
 
		public String WLNatCode { get; set; }  
 
		public String WLPCName { get; set; }  
 
		public DateTime WLDateTime { get; set; }  
 
		public DateTime WLExit { get; set; }  
 
		public Int32 WLState { get; set; } 
    }
}


