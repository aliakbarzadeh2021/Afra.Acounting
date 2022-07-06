using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayBuyCalc : BaseEntity
    {
          
 
		public Int32 PayBuyCalcId { get; set; }  
 
		public Int32 PBCPersRef { get; set; }  
 
		public Double PBCBaseVal { get; set; }  
 
		public Int32 PBCDays { get; set; } 
    }
}


