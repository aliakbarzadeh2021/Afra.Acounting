using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class TrsCreditTblDto
    {
          
 
		public Int32 TrsCreditTblId { get; set; }  
 
		public Nullable<Int32> TCTType { get; set; }  
 
		public String TCTDescr { get; set; }  
 
		public DateTime TCTDate { get; set; } 
    }
}


