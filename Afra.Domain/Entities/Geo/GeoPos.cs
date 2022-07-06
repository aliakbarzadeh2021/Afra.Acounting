using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GeoPos : BaseEntity
    {
          
 
		public Int32 GeoPosId { get; set; }  
 
		public Nullable<Int32> GeoPostParent { get; set; }  
 
		public String GeoPostTitle { get; set; } 
    }
}


