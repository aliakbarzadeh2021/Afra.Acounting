using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SleSrvPrcItm : BaseEntity
    {
          
 
		public Int32 SleSrvPrcItmId { get; set; }  
 
		public Int32 SleSrvPrcHdrRef { get; set; }  
 
		public Nullable<Int32> SSPISeq { get; set; }  
 
		public Nullable<Int32> SSPIItemRef { get; set; }  
 
		public Nullable<Int32> SSPIUnitRef { get; set; }  
 
		public Double SSPIMinQty { get; set; }  
 
		public Double SSPIMaxQty { get; set; }  
 
		public Double SSPIUnitSrvPrc { get; set; } 
    }
}


