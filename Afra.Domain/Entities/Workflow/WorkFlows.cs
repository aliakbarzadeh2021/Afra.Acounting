using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class WorkFlows : BaseEntity
    {
          
 
		public Int32 WorkFlowId { get; set; }  
 
		public String WFTitle { get; set; }  
 
		public Int32 WFType { get; set; }  
 
		public Nullable<Int32> WFState { get; set; } 
    }
}


