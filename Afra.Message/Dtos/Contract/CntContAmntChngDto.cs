using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CntContAmntChngDto
    {
          
 
		public Int32 CntContAmntChngId { get; set; }  
 
		public Int32 CCACContRef { get; set; }  
 
		public Int32 CCACType { get; set; }  
 
		public DateTime CCACDate { get; set; }  
 
		public String CCACDescr { get; set; }  
 
		public Double CCACVal { get; set; } 
    }
}


