using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CstAccDataDto
    {
          
 
		public Int32 CADPeriodRef { get; set; }  
 
		public String CADSLRef { get; set; }  
 
		public String CADDLRef { get; set; }  
 
		public String CADDLFive { get; set; }  
 
		public String CADDLSix { get; set; }  
 
		public Nullable<Double> CADDebit { get; set; }  
 
		public Nullable<Double> CADCredit { get; set; } 
    }
}


