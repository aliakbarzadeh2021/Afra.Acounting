using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class Lookups : BaseEntity
    {
          
 
		public String LkpId { get; set; }  
 
		public String LkpType { get; set; }  
 
		public String LkpTitle { get; set; }  
 
		public Nullable<Int32> LkpOrder { get; set; } 
    }
}


