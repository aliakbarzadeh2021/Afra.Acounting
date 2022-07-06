using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class WebImages : BaseEntity
    {
          
 
		public Int32 WebImageId { get; set; }  
 
		public Int32 WIPersRef { get; set; }  
 
		public DateTime WIDate { get; set; }  
 
		public String WIType { get; set; }  
 
		public Byte[] WIData { get; set; } 
    }
}


