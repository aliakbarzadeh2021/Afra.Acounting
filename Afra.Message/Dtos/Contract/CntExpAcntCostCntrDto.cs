using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CntExpAcntCostCntrDto
    {
          
 
		public Int32 CntExpAcntCostCntrId { get; set; }  
 
		public Int32 CEACExpAcntRef { get; set; }  
 
		public Int32 CEACCostRef { get; set; }  
 
		public Double CEACAmount { get; set; }  
 
		public Nullable<Double> CEACCurVal { get; set; } 
    }
}


