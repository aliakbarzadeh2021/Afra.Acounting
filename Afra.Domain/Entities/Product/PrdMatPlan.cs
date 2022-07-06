using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PrdMatPlan : BaseEntity
    {
          
 
		public Int32 PrdMatPlanId { get; set; }  
 
		public Int32 PMPMatRef { get; set; }  
 
		public Nullable<Int32> PMPFixTime { get; set; }  
 
		public Nullable<Int32> PMPVarTime { get; set; }  
 
		public Int32 PMPPlanType { get; set; }  
 
		public Nullable<Double> PMPPlanQty { get; set; } 
    }
}


