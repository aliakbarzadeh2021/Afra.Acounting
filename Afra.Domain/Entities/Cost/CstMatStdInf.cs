using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CstMatStdInf : BaseEntity
    {
          
 
		public Int32 CMSMatRef { get; set; }  
 
		public Nullable<Double> CMSAmnt { get; set; }  
 
		public Nullable<Double> CMSRatio { get; set; }  
 
		public Int32 CMSPeriodId { get; set; } 
    }
}


