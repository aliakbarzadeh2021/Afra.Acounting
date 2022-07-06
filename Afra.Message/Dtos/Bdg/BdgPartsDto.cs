using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class BdgPartsDto
    {
          
 
		public Int32 BdgPartsId { get; set; }  
 
		public Int32 BPType { get; set; }  
 
		public String BPTitle { get; set; }  
 
		public DateTime BPDate { get; set; }  
 
		public Int32 BPQty { get; set; }  
 
		public Double BPPrice { get; set; }  
 
		public Nullable<Double> BPCost { get; set; }  
 
		public Nullable<Int32> BPPeriodRef { get; set; }  
 
		public String BPSLCode { get; set; }  
 
		public String BPSLCode2 { get; set; }  
 
		public Nullable<Int32> BPCurRef { get; set; }  
 
		public Nullable<Int32> BPInvCtgry { get; set; }  
 
		public Nullable<Int32> BPSleCtgry { get; set; } 
    }
}


