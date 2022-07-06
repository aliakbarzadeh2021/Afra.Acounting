using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntSrvPrcItm : BaseEntity
    {
          
 
		public Int32 CntSrvPrcItmId { get; set; }  
 
		public Int32 CntSrvPrcHdrRef { get; set; }  
 
		public Nullable<Int32> CSPISeq { get; set; }  
 
		public Nullable<Int32> CSPIItemRef { get; set; }  
 
		public Nullable<Int32> CSPIUnitRef { get; set; }  
 
		public Double CSPIMinQty { get; set; }  
 
		public Double CSPIMaxQty { get; set; }  
 
		public Double CSPIUnitSrvPrc { get; set; } 
    }
}


