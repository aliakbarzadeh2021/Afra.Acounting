using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class SleBrokerCalcDto
    {
          
 
		public Int32 SleBrokerCalcId { get; set; }  
 
		public Int32 SBCSalaryRef { get; set; }  
 
		public Int32 SBCBrokerRef { get; set; }  
 
		public DateTime SBCFDate { get; set; }  
 
		public DateTime SBCEDate { get; set; }  
 
		public Double SBCBaseAmnt { get; set; }  
 
		public Double SBCAmount { get; set; } 
    }
}


