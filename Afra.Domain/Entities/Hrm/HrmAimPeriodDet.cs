using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmAimPeriodDet : BaseEntity
    {
          
 
		public Int32 HAPDPeriodRef { get; set; }  
 
		public Int32 HAPDPersRef { get; set; }  
 
		public Int32 HAPDElmntRef { get; set; }  
 
		public Nullable<Double> HAPDVal { get; set; } 
    }
}


