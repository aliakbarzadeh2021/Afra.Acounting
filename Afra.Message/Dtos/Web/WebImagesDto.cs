using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class WebImagesDto
    {
          
 
		public Int32 WebImageId { get; set; }  
 
		public Int32 WIPersRef { get; set; }  
 
		public DateTime WIDate { get; set; }  
 
		public String WIType { get; set; }  
 
		public Byte[] WIData { get; set; } 
    }
}


