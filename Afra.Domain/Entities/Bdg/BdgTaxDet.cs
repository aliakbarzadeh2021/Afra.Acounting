using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgTaxDet : BaseEntity
    {
          
 
		public Int32 BdgTaxDetId { get; set; }  
 
		public Int32 BTDType { get; set; }  
 
		public Int32 BTDParentRef { get; set; }  
 
		public Int32 BTDTaxRef { get; set; }  
 
		public Nullable<Int32> BTDPriority { get; set; }  
 
		public Double BTDVal { get; set; } 
    }
}


