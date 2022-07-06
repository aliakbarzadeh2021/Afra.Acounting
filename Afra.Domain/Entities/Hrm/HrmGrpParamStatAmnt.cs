using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmGrpParamStatAmnt : BaseEntity
    {
          
 
		public Int32 HGPSParamRef { get; set; }  
 
		public Int32 HGPSStatRef { get; set; }  
 
		public Nullable<Double> HGPSAmount { get; set; }  
 
		public Nullable<Int32> HGPSSit { get; set; } 
    }
}


