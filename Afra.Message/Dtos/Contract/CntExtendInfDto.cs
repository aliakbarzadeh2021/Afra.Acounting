using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CntExtendInfDto
    {
          
 
		public Int32 CntExtendInfId { get; set; }  
 
		public Int32 CEIBaseItm { get; set; }  
 
		public Int32 CEIBaseType { get; set; }  
 
		public DateTime CEIFromDate { get; set; }  
 
		public String CEIDur { get; set; }  
 
		public Nullable<Double> CEIAmnt { get; set; }  
 
		public String CEIExtType { get; set; } 
    }
}


