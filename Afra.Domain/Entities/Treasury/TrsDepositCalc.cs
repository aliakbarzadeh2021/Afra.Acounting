using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsDepositCalc : BaseEntity
    {
          
 
		public Int32 TrsDepositCalcId { get; set; }  
 
		public Int32 TDCItemRef { get; set; }  
 
		public Int32 TDCYear { get; set; }  
 
		public Int32 TDCMonth { get; set; }  
 
		public Double TDCAmount { get; set; } 
    }
}


