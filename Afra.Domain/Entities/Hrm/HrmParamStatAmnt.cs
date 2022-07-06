using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmParamStatAmnt : BaseEntity
    {
          
 
		public Int32 HPSAStatRef { get; set; }  
 
		public Int32 HPSAParamRef { get; set; }  
 
		public Nullable<Double> HPSAAmount { get; set; } 
    }
}


