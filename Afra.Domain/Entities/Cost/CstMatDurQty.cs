using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CstMatDurQty : BaseEntity
    {
          
 
		public Int32 CstMatDurQtyId { get; set; }  
 
		public Nullable<Int32> CMDQType { get; set; }  
 
		public Nullable<Int32> CMDQPartRef { get; set; }  
 
		public Nullable<Int32> CMDQCostCntrRef { get; set; }  
 
		public Nullable<Int32> CMDQPeriodId { get; set; }  
 
		public Nullable<Double> CMDQQty { get; set; }  
 
		public Nullable<Double> CMDQAmount { get; set; } 
    }
}


