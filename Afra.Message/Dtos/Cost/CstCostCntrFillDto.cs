using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CstCostCntrFillDto
    {
          
 
		public Int32 CCnFCostCenter { get; set; }  
 
		public Int32 CCnFPeriodId { get; set; }  
 
		public Nullable<Double> CCnFHrmTime { get; set; }  
 
		public Nullable<Double> CCnFCstTime { get; set; }  
 
		public Nullable<Double> CCnFPkgHrmTime { get; set; }  
 
		public Nullable<Double> CCnFPkgCstTime { get; set; } 
    }
}


