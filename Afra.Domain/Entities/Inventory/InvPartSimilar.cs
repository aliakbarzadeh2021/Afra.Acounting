using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class InvPartSimilar : BaseEntity
    {
          
 
		public Int32 InvPartSimilarId { get; set; }  
 
		public Int32 IPSMainPartRef { get; set; }  
 
		public Int32 IPSSimiPartRef { get; set; }  
 
		public Int32 IPSOrder { get; set; }  
 
		public Nullable<Double> IPSRatio { get; set; } 
    }
}


