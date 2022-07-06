using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class QcsDocsDto
    {
          
 
		public Int32 QcsDocId { get; set; }  
 
		public String QDCode { get; set; }  
 
		public String QDTitle { get; set; }  
 
		public String QDFileExt { get; set; }  
 
		public Byte[] QDImage { get; set; } 
    }
}


