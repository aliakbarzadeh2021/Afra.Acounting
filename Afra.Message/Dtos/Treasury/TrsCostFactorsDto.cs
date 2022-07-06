using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class TrsCostFactorsDto
    {
          
 
		public Int32 TrsCostFactorId { get; set; }  
 
		public Int32 TCFCode { get; set; }  
 
		public Nullable<Int32> TCFParent { get; set; }  
 
		public String TCFTitle { get; set; }  
 
		public String TCFSLRef { get; set; }  
 
		public String TCFDLRef { get; set; }  
 
		public String TCFDLFive { get; set; }  
 
		public String TCFDLSix { get; set; } 
    }
}


