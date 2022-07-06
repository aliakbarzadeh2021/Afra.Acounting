using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PrdOrdItmDto
    {
          
 
		public Int32 PrdOrdItmId { get; set; }  
 
		public Int32 POISeq { get; set; }  
 
		public Int32 PrdOrdHdrRef { get; set; }  
 
		public Nullable<Int32> POIPartRef { get; set; }  
 
		public Nullable<Int32> POIUnitRef { get; set; }  
 
		public Nullable<Double> POIOthQty { get; set; }  
 
		public Nullable<Double> POIMainQty { get; set; }  
 
		public String POIDescr { get; set; }  
 
		public DateTime POINeedDate { get; set; }  
 
		public Nullable<Int32> POIStatus { get; set; }  
 
		public Nullable<Int32> POIRefID { get; set; }  
 
		public Nullable<Int32> POIRefType { get; set; } 
    }
}


