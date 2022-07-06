using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class OtoCtgry : BaseEntity
    {
          
 
		public Int32 OtoCtgryId { get; set; }  
 
		public Nullable<Int32> OCParent { get; set; }  
 
		public String OCTitle { get; set; } 
    }
}


