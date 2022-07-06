using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgTaxPrcCost : BaseEntity
    {
          
 
		public Int32 BTPCItemRef { get; set; }  
 
		public String BTPCSLCode { get; set; }  
 
		public Int32 BTPCCalcType { get; set; } 
    }
}


