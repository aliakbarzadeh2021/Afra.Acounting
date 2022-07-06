using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class BdgHrmValsDto
    {
          
 
		public Int32 BdgHrmValsId { get; set; }  
 
		public Int32 BHVCostCntrRef { get; set; }  
 
		public Int32 BHVElmntRef { get; set; }  
 
		public Double BHVAmount { get; set; }  
 
		public Int32 BHVPeriodRef { get; set; }  
 
		public Nullable<Int32> BHVCurRef { get; set; } 
    }
}


