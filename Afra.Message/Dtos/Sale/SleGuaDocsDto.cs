using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class SleGuaDocsDto
    {
          
 
		public Int32 SleGuaDocId { get; set; }  
 
		public String SGDNum { get; set; }  
 
		public Int32 SGDFactRef { get; set; }  
 
		public DateTime SGDStDate { get; set; }  
 
		public DateTime SGDEnDate { get; set; }  
 
		public String SGDDescr { get; set; } 
    }
}


