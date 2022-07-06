using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SleVchTypes : BaseEntity
    {
          
 
		public Int32 SleVchTypeId { get; set; }  
 
		public String SVTTitle { get; set; }  
 
		public Nullable<Int32> SVTInvVch { get; set; }  
 
		public Nullable<Int32> SVTBaseLimit { get; set; } 
    }
}


