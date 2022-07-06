using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CmrReleaseCost : BaseEntity
    {
          
 
		public Int32 CmrReleaseCostId { get; set; }  
 
		public Int32 CRCItmRef { get; set; }  
 
		public String CRCDescr { get; set; }  
 
		public Double CRCAmount { get; set; } 
    }
}


