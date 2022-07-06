using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CmrInvoiceCost : BaseEntity
    {
          
 
		public Int32 CmrInvoiceCostId { get; set; }  
 
		public Int32 CICItmRef { get; set; }  
 
		public String CICDescr { get; set; }  
 
		public Double CICAmount { get; set; } 
    }
}


