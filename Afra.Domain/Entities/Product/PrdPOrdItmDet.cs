using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PrdPOrdItmDet : BaseEntity
    {
          
 
		public Int32 PPOIDItmRef { get; set; }  
 
		public Int32 PPOIDPartRef { get; set; }  
 
		public Nullable<Int32> PPOIDFrmlRef { get; set; }  
 
		public Nullable<Int32> PPOIDLev { get; set; }  
 
		public Nullable<Double> PPOIDQty { get; set; } 
    }
}


