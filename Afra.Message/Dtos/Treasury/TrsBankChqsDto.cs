using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class TrsBankChqsDto
    {
          
 
		public Int32 BankChqId { get; set; }  
 
		public Int32 BChqBeginSerial { get; set; }  
 
		public Int32 BChqShtCnt { get; set; }  
 
		public Int32 BChqAcnRef { get; set; }  
 
		public Nullable<Int32> BChqFmtRef { get; set; } 
    }
}


