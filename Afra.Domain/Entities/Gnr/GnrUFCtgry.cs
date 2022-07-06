using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrUFCtgry : BaseEntity
    {
          
 
		public Int32 GnrUFCtgryId { get; set; }  
 
		public Nullable<Int32> GUFCParent { get; set; }  
 
		public String GUFTitle { get; set; } 
    }
}


