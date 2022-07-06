using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CstStdAccDataDto
    {
          
 
		public Int32 CSADPeriodRef { get; set; }  
 
		public String CSADSLRef { get; set; }  
 
		public String CSADDLRef { get; set; }  
 
		public String CSADDLFive { get; set; }  
 
		public String CSADDLSix { get; set; }  
 
		public Nullable<Double> CSADDebit { get; set; }  
 
		public Nullable<Double> CSADCredit { get; set; } 
    }
}


