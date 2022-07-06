using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CstCostCntrAllocDto
    {
          
 
		public Int32 CstCostCntAllocId { get; set; }  
 
		public Nullable<Int32> CCnACostCntRef { get; set; }  
 
		public Nullable<Int32> CCnARoleRef { get; set; }  
 
		public Nullable<Int32> CCnAPeriodId { get; set; }  
 
		public Nullable<Double> CCnAPrc { get; set; } 
    }
}


