using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class InvStockUser : BaseEntity
    {
          
 
		public Int32 InvStockUserId { get; set; }  
 
		public Int32 ISUStockRef { get; set; }  
 
		public Int32 ISUUserRef { get; set; }  
 
		public Nullable<Int32> ISURight { get; set; } 
    }
}


