using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AccDLCtgry : BaseEntity
    {
          
 
		public Int32 AccDLCtgryId { get; set; }  
 
		public Nullable<Int32> ADCParentRef { get; set; }  
 
		public String ADCTitle { get; set; } 
    }
}


