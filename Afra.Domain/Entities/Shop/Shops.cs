using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class Shops : BaseEntity
    {
          
 
		public Int32 ShopsId { get; set; }  
 
		public String ShopName { get; set; }  
 
		public String ShopDb { get; set; }  
 
		public Nullable<Int32> ShopSaleBranch { get; set; }  
 
		public Nullable<Int32> ShopStock { get; set; } 
    }
}


