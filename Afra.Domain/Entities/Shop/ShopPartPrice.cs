using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class ShopPartPrice : BaseEntity
    {
          
 
		public Int32 ShopPartPriceId { get; set; }  
 
		public DateTime SPPDate { get; set; }  
 
		public Int32 SPPPartRef { get; set; }  
 
		public Int32 SPPSaleType { get; set; }  
 
		public Double SPPVal { get; set; } 
    }
}


