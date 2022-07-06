using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmStatMthdDet : BaseEntity
    {
          
 
		public Int32 HrmStatMthdDetId { get; set; }  
 
		public Nullable<Int32> HSMDMthdRef { get; set; }  
 
		public String HSMDParamName { get; set; }  
 
		public String HSMDParamTitle { get; set; }  
 
		public String HSMDMainParam { get; set; } 
    }
}


