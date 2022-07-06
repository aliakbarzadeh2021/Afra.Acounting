using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class ShopGiftPart : BaseEntity
    {
          
 
		public Int32 ShopGiftPartId { get; set; }  
 
		public Int32 SGPPartRef { get; set; }  
 
		public DateTime SGPDate { get; set; }  
 
		public Double SGPVchAmnt { get; set; }  
 
		public Double SGPVal { get; set; } 
    }
}


