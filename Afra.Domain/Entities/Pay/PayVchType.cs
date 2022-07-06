using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayVchType : BaseEntity
    {
          
 
		public Int32 PayVchTypeId { get; set; }  
 
		public String PVTTitle { get; set; }  
 
		public Nullable<Int32> PVTType { get; set; } 
    }
}


