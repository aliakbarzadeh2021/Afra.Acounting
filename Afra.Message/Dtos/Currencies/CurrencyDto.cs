using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CurrencyDto
    {
          
 
		public Int32 CurrencyId { get; set; }  
 
		public String CurTitle { get; set; }  
 
		public Nullable<Int32> CurDigitCnt { get; set; }  
 
		public String CurDigitTitle { get; set; } 
    }
}


