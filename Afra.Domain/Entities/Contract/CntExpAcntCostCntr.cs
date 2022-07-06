using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntExpAcntCostCntr : BaseEntity
    {
          
 
		public Int32 CntExpAcntCostCntrId { get; set; }  
 
		public Int32 CEACExpAcntRef { get; set; }  
 
		public Int32 CEACCostRef { get; set; }  
 
		public Double CEACAmount { get; set; }  
 
		public Nullable<Double> CEACCurVal { get; set; } 
    }
}


