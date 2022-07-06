using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class BdgLevelDetDto
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


