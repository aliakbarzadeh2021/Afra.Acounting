using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CurExChangeDto
    {
          
 
		public Int32 CurExchangeId { get; set; }  
 
		public Int32 CExMainCurRef { get; set; }  
 
		public Int32 CExRelCurRef { get; set; }  
 
		public DateTime CExDate { get; set; }  
 
		public Double CExRate { get; set; } 
    }
}


