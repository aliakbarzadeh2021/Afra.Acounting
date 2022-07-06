using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgAssetsDet : BaseEntity
    {
          
 
		public Int32 BADParentRef { get; set; }  
 
		public Int32 BADMonth { get; set; }  
 
		public Nullable<Double> BADAstCost { get; set; }  
 
		public Nullable<Double> BADDepr { get; set; } 
    }
}


