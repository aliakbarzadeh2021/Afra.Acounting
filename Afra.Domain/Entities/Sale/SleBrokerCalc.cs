using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SleBrokerCalc : BaseEntity
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


