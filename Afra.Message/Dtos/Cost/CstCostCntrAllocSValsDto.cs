using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CstCostCntrAllocSValsDto
    {
          
 
		public Int32 CstCostCntrAllocSValId { get; set; }  
 
		public Int32 CCASVPutCostId { get; set; }  
 
		public Int32 CCASVRcvCostId { get; set; }  
 
		public String CCASVSLRef { get; set; }  
 
		public Nullable<Double> CCASVValue { get; set; }  
 
		public Int32 CCASVPeriodId { get; set; } 
    }
}


