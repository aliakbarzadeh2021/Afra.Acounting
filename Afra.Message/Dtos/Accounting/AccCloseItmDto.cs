using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class AccCloseItmDto
    {
          
 
		public Int32 AccCloseItmId { get; set; }  
 
		public Nullable<Int32> AccCloseHdrRef { get; set; }  
 
		public String ACIGLRef { get; set; }  
 
		public String ACISLRef { get; set; }  
 
		public String ACIDLRef { get; set; }  
 
		public String ACIDLFive { get; set; }  
 
		public String ACIDLSix { get; set; } 
    }
}


