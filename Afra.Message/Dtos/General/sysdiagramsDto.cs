using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class sysdiagramsDto
    {
          
 
		public String name { get; set; }  
 
		public Int32 principal_id { get; set; }  
 
		public Int32 diagram_id { get; set; }  
 
		public Nullable<Int32> version { get; set; }  
 
		public Byte[] definition { get; set; } 
    }
}


