using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CstMatWastDto
    {
          
 
		public Int32 CstMatWastId { get; set; }  
 
		public Nullable<Int32> CMWPeriodId { get; set; }  
 
		public DateTime CMWDate { get; set; }  
 
		public Nullable<Int32> CMWCostCntrRef { get; set; }  
 
		public Nullable<Int32> CMWPartRef { get; set; }  
 
		public Nullable<Double> CMWQty { get; set; } 
    }
}


