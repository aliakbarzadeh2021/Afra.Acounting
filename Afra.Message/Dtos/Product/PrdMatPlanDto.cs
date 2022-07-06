using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PrdMatPlanDto
    {
          
 
		public Int32 PrdMatPlanId { get; set; }  
 
		public Int32 PMPMatRef { get; set; }  
 
		public Nullable<Int32> PMPFixTime { get; set; }  
 
		public Nullable<Int32> PMPVarTime { get; set; }  
 
		public Int32 PMPPlanType { get; set; }  
 
		public Nullable<Double> PMPPlanQty { get; set; } 
    }
}


