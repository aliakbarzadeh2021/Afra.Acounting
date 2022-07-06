using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class InvPartPrice : BaseEntity
    {
          
 
		public Int32 IPPPartRef { get; set; }  
 
		public Int32 IIPAccPrdRef { get; set; }  
 
		public Nullable<Double> IPPRatio { get; set; }  
 
		public Int32 IPPType { get; set; } 
    }
}


