using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class BdgCostCntrAllocDto
    {
          
 
		public Int32 BdgCostCntAllocId { get; set; }  
 
		public Nullable<Int32> BCnACostCntRef { get; set; }  
 
		public Nullable<Int32> BCnAElmntRef { get; set; }  
 
		public Nullable<Int32> BCnARoleRef { get; set; }  
 
		public Nullable<Int32> BCnAPeriodId { get; set; }  
 
		public Nullable<Double> BCnAPrc { get; set; } 
    }
}


