using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CmrFactItmDto
    {
          
 
		public Int32 CmrFactItmId { get; set; }  
 
		public Int32 CFISeq { get; set; }  
 
		public Int32 CmrFactHdrRef { get; set; }  
 
		public Int32 CFIItmType { get; set; }  
 
		public Int32 CFIItmRef { get; set; }  
 
		public Nullable<Double> CFIOthQty { get; set; }  
 
		public Nullable<Double> CFIMainQty { get; set; }  
 
		public Nullable<Double> CFIAmount { get; set; }  
 
		public Nullable<Double> CFIIncAmnt { get; set; }  
 
		public Nullable<Double> CFIDecAmnt { get; set; }  
 
		public String CFIDescr { get; set; }  
 
		public Nullable<Int32> CFIStatus { get; set; } 
    }
}


