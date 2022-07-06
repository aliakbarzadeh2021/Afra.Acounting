using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class StkStockersDto
    {
          
 
		public Int32 StkStockerId { get; set; }  
 
		public Int32 SSCrspndRef { get; set; }  
 
		public String SSCode { get; set; }  
 
		public String SSFatherName { get; set; }  
 
		public String SSCertNo { get; set; }  
 
		public DateTime SSBirthDate { get; set; }  
 
		public Nullable<Int32> SSBirthLocRef { get; set; }  
 
		public Nullable<Int32> SSIssuedIDLoc { get; set; }  
 
		public DateTime SSIssueDate { get; set; }  
 
		public String SSNatCode { get; set; }  
 
		public String SSAcnNo { get; set; }  
 
		public String SSBourceCode { get; set; }  
 
		public String SSAddress { get; set; }  
 
		public String SSRespName { get; set; } 
    }
}


