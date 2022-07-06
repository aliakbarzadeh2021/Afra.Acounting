using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PrdConsumItm : BaseEntity
    {
          
 
		public Int32 PrdConsumItmId { get; set; }  
 
		public Nullable<Int32> PrdConsumHdrRef { get; set; }  
 
		public Nullable<Int32> PCISeq { get; set; }  
 
		public Int32 PCIPartRef { get; set; }  
 
		public Nullable<Int32> PCIUnitRef { get; set; }  
 
		public Double PCIQty { get; set; }  
 
		public String PCIDescr { get; set; } 
    }
}


