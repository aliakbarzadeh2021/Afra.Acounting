using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class TrsGuaranteeOprDto
    {
          
 
		public Int32 TrsGuaranteeOprId { get; set; }  
 
		public Int32 TGOItemRef { get; set; }  
 
		public DateTime TGOOprDate { get; set; }  
 
		public Int32 TGOType { get; set; }  
 
		public Nullable<Double> TGOAmount { get; set; }  
 
		public DateTime TGODate { get; set; }  
 
		public Nullable<Double> TGOTaxAmnt { get; set; }  
 
		public Nullable<Double> TGODutyAmnt { get; set; }  
 
		public Nullable<Int32> TGOCreator { get; set; }  
 
		public Nullable<Int32> TGOSit { get; set; } 
    }
}


