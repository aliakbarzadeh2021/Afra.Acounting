using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class HrmGrpParamStatDto
    {
          
 
		public Int32 HrmGrpParamStatId { get; set; }  
 
		public Nullable<Int32> HGPSNum { get; set; }  
 
		public DateTime HGPSIssueDate { get; set; }  
 
		public DateTime HGPSEffectDate { get; set; }  
 
		public String HGPSDescr { get; set; } 
    }
}


