using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CmrInsuranceDto
    {
          
 
		public Int32 CmrInsuranceId { get; set; }  
 
		public String CINum { get; set; }  
 
		public Int32 CIFactRef { get; set; }  
 
		public Int32 CICompRef { get; set; }  
 
		public DateTime CIDate { get; set; }  
 
		public DateTime CIRegDate { get; set; }  
 
		public DateTime CIEndDate { get; set; }  
 
		public String CIType { get; set; }  
 
		public Nullable<Int32> CIFromLoc { get; set; }  
 
		public Nullable<Int32> CIToLoc { get; set; }  
 
		public String CITransType { get; set; }  
 
		public String CICoverage { get; set; }  
 
		public String CICoverDescr { get; set; }  
 
		public Double CIAllAmnt { get; set; }  
 
		public Double CIInsuAmnt { get; set; }  
 
		public Nullable<Int32> CICurRef { get; set; }  
 
		public Nullable<Double> CICurRate { get; set; } 
    }
}


