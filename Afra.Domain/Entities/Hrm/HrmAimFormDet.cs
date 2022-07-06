using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmAimFormDet : BaseEntity
    {
          
 
		public Int32 HAFDFormRef { get; set; }  
 
		public Int32 HAFDElmntRef { get; set; }  
 
		public Nullable<Double> HAFDRatio { get; set; } 
    }
}


