using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class InvVchItmRate : BaseEntity
    {
          
 
		public Int32 InvItmRateId { get; set; }  
 
		public Nullable<Int32> InvVchItmRef { get; set; }  
 
		public Int32 IVRType { get; set; }  
 
		public String IVRDescr { get; set; }  
 
		public Double IVRMainAmount { get; set; }  
 
		public DateTime IVRDate { get; set; } 
    }
}


