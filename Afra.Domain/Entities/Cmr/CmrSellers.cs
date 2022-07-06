using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CmrSellers : BaseEntity
    {
          
 
		public Int32 CmrSellerId { get; set; }  
 
		public Int32 CSCrspndRef { get; set; }  
 
		public Int32 CSType { get; set; }  
 
		public Nullable<Int32> CSActive { get; set; }  
 
		public Nullable<Int32> CSGroupRef { get; set; } 
    }
}


