using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgElmntValsDet : BaseEntity
    {
          
 
		public Int32 BEVDParentRef { get; set; }  
 
		public Int32 PEVDMonth { get; set; }  
 
		public Nullable<Double> PEVDVal { get; set; }  
 
		public Int32 BEVDMonth { get; set; }  
 
		public Nullable<Double> BEVDVal { get; set; } 
    }
}


