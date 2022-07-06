using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class QcsRequestDto
    {
          
 
		public Int32 QcsRequestId { get; set; }  
 
		public Int32 QRNum { get; set; }  
 
		public DateTime QRDate { get; set; }  
 
		public String QRDLRef { get; set; }  
 
		public Nullable<Int32> QRPartRef { get; set; }  
 
		public String QRStepName { get; set; }  
 
		public Nullable<Double> QRQty { get; set; }  
 
		public String QRDescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> QRState { get; set; }  
 
		public Int32 QRAccPrdRef { get; set; } 
    }
}


