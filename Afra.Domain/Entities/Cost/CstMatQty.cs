using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CstMatQty : BaseEntity
    {
          
 
		public Int32 CstMatQtyId { get; set; }  
 
		public Nullable<Int32> CMQPeriodId { get; set; }  
 
		public Nullable<Int32> CMQCostCntrRef { get; set; }  
 
		public Nullable<Int32> CMQPartRef { get; set; }  
 
		public Nullable<Double> CMQQty { get; set; }  
 
		public Nullable<Double> CMQAmount { get; set; } 
    }
}


