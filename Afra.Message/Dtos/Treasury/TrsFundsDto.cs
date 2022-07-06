using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class TrsFundsDto
    {
          
 
		public Int32 TrsFundId { get; set; }  
 
		public String TFTitle { get; set; }  
 
		public Nullable<Int32> TFCrsRef { get; set; }  
 
		public DateTime TFOpenDate { get; set; }  
 
		public Double TFBeginAmnt { get; set; }  
 
		public Nullable<Double> TFMaxAmnt { get; set; }  
 
		public String TFSLRef { get; set; }  
 
		public String TFDLRef { get; set; }  
 
		public String TFDLFive { get; set; }  
 
		public String TFDLSix { get; set; } 
    }
}


