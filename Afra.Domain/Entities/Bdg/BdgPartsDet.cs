using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgPartsDet : BaseEntity
    {
          
 
		public Int32 BPDParentRef { get; set; }  
 
		public Int32 BPDMonth { get; set; }  
 
		public Nullable<Double> BPDQty { get; set; }  
 
		public Nullable<Double> BPDPrice { get; set; }  
 
		public Nullable<Double> BPDCost { get; set; } 
    }
}


