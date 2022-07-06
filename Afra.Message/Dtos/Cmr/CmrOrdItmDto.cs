using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CmrOrdItmDto
    {
          
 
		public Int32 CmrOrdItmId { get; set; }  
 
		public Int32 COISeq { get; set; }  
 
		public Int32 CmrOrdHdrRef { get; set; }  
 
		public Int32 COIRqstRef { get; set; }  
 
		public Nullable<Double> COIOthQty { get; set; }  
 
		public Nullable<Double> COIMainQty { get; set; }  
 
		public Nullable<Double> COIAmount { get; set; }  
 
		public String COIDescr { get; set; }  
 
		public Nullable<Int32> COIStatus { get; set; } 
    }
}


