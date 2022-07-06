using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CstCostCntrAllocValsDto
    {
          
 
		public Int32 CstCostCntrAllocValId { get; set; }  
 
		public Int32 CCAVPutCostId { get; set; }  
 
		public Int32 CCAVRcvCostId { get; set; }  
 
		public String CCAVSLRef { get; set; }  
 
		public Nullable<Double> CCAVValue { get; set; }  
 
		public Int32 CCAVPeriodId { get; set; } 
    }
}


