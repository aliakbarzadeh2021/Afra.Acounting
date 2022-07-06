using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PmiReqPart : BaseEntity
    {
          
 
		public Int32 PMIReqPartId { get; set; }  
 
		public Int32 PRPPrjRef { get; set; }  
 
		public Int32 PRPPartRef { get; set; }  
 
		public DateTime PRPDate { get; set; }  
 
		public Nullable<Double> PRPQty { get; set; }  
 
		public Nullable<Int32> PRPCreator { get; set; } 
    }
}


