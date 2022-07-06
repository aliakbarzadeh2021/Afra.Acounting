using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntDeliveryInf : BaseEntity
    {
          
 
		public Int32 CntDeliveryInfId { get; set; }  
 
		public Int32 CDIContRef { get; set; }  
 
		public String CDIType { get; set; }  
 
		public DateTime CDIDate { get; set; } 
    }
}


