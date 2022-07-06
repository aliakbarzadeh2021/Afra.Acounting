using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class WorkFlowsDto
    {
          
 
		public Int32 WorkFlowId { get; set; }  
 
		public String WFTitle { get; set; }  
 
		public Int32 WFType { get; set; }  
 
		public Nullable<Int32> WFState { get; set; } 
    }
}


