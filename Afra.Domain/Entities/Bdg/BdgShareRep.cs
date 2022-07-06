using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgShareRep : BaseEntity
    {
          
 
		public Int32 BdgShareRepId { get; set; }  
 
		public Int32 BSRPeriodId { get; set; }  
 
		public String BSRCstLevel { get; set; }  
 
		public String BSRPutCst { get; set; }  
 
		public String BSRRcvCst { get; set; }  
 
		public Double BSRCostVal { get; set; } 
    }
}


