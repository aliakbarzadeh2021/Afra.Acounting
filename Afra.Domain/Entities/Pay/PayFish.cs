using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayFish : BaseEntity
    {
          
 
		public Int32 PayFishId { get; set; }  
 
		public String PFTitle { get; set; }  
 
		public String PFFileName { get; set; } 
    }
}


