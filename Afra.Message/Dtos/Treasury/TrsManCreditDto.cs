using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class TrsManCreditDto
    {
          
 
		public Int32 TrsManCreditId { get; set; }  
 
		public Int32 TMCType { get; set; }  
 
		public Int32 TMCCrspndRef { get; set; }  
 
		public Int32 TMCKind { get; set; }  
 
		public Double TMCAmount { get; set; }  
 
		public String TMCDescr { get; set; } 
    }
}


