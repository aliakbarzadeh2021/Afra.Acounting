using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CstProductVch : BaseEntity
    {
          
 
		public Int32 CstProductVchId { get; set; }  
 
		public Int32 CPVPeriodId { get; set; }  
 
		public Int32 CPVPartRef { get; set; }  
 
		public Int32 CPVFormulaRef { get; set; }  
 
		public Int32 CPVCostCntrRef { get; set; }  
 
		public Int32 CPVNum { get; set; }  
 
		public DateTime CPVDate { get; set; }  
 
		public Int32 CPVType { get; set; }  
 
		public Double CPVQty { get; set; } 
    }
}


