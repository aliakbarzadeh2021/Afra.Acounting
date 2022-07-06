using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class InvPartSimilarDto
    {
          
 
		public Int32 InvPartSimilarId { get; set; }  
 
		public Int32 IPSMainPartRef { get; set; }  
 
		public Int32 IPSSimiPartRef { get; set; }  
 
		public Int32 IPSOrder { get; set; }  
 
		public Nullable<Double> IPSRatio { get; set; } 
    }
}


