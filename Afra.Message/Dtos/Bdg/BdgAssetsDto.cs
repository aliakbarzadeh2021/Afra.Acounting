using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class BdgAssetsDto
    {
          
 
		public Int32 BdgAssetsId { get; set; }  
 
		public Int32 BAType { get; set; }  
 
		public String BATitle { get; set; }  
 
		public Int32 BAGrpRef { get; set; }  
 
		public DateTime BAStartDate { get; set; }  
 
		public DateTime BAUseDate { get; set; }  
 
		public Nullable<Double> BAFirstDepr { get; set; }  
 
		public Int32 BAQty { get; set; }  
 
		public Double BAPrice { get; set; }  
 
		public Int32 BAMethod { get; set; }  
 
		public Double BARatio { get; set; }  
 
		public Int32 BAPeriodRef { get; set; }  
 
		public String BASLCode { get; set; }  
 
		public Double BACost { get; set; }  
 
		public Nullable<Int32> BACurRef { get; set; }  
 
		public Nullable<Int32> BABaseType { get; set; } 
    }
}


