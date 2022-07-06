using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CstMatDurQtyDto
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


