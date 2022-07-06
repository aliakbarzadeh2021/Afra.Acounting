using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgLevelDet : BaseEntity
    {
          
 
		public Int32 BdgLevelDetId { get; set; }  
 
		public Int32 BLDType { get; set; }  
 
		public Int32 BLDParentRef { get; set; }  
 
		public String BLDDLRef { get; set; }  
 
		public String BLDDL5Ref { get; set; }  
 
		public String BLDDL6Ref { get; set; }  
 
		public String BLDDL7Ref { get; set; }  
 
		public Double BLDPercent { get; set; } 
    }
}


