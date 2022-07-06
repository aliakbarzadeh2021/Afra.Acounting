using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class InvItmRateDetDto
    {
          
 
		public Int32 InvItmRateDetId { get; set; }  
 
		public Int32 InvVchItmRef { get; set; }  
 
		public Nullable<Double> IIRDDisCount { get; set; }  
 
		public Nullable<Double> IIRDPrePay { get; set; }  
 
		public Nullable<Double> IIRDTrans { get; set; }  
 
		public Nullable<Double> IIRDOther { get; set; }  
 
		public Nullable<Double> IIRDTax { get; set; }  
 
		public Nullable<Double> IIRDDuty { get; set; }  
 
		public String IIRDTransDL { get; set; }  
 
		public String IIRDOtherDL { get; set; } 
    }
}


