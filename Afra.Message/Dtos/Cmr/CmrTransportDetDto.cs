using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CmrTransportDetDto
    {
          
 
		public Int32 CmrTransportDetId { get; set; }  
 
		public Int32 CTDItmRef { get; set; }  
 
		public Int32 CTDType { get; set; }  
 
		public Nullable<Double> CTDQty { get; set; }  
 
		public Nullable<Double> CTDGross { get; set; }  
 
		public Nullable<Int32> CTDUnitRef { get; set; }  
 
		public Nullable<Double> CTDVolume { get; set; }  
 
		public Nullable<Int32> CTDVolUnitRef { get; set; }  
 
		public String CTDDescr { get; set; } 
    }
}


