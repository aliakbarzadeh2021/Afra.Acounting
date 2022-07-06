using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayValStatAmnt : BaseEntity
    {
          
 
		public Int32 PVSAStatRef { get; set; }  
 
		public Int32 PVSAElmntRef { get; set; }  
 
		public Nullable<Double> PVSAAmount { get; set; } 
    }
}


