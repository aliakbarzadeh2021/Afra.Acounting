using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsBankChqs : BaseEntity
    {
          
 
		public Int32 BankChqId { get; set; }  
 
		public Int32 BChqBeginSerial { get; set; }  
 
		public Int32 BChqShtCnt { get; set; }  
 
		public Int32 BChqAcnRef { get; set; }  
 
		public Nullable<Int32> BChqFmtRef { get; set; } 
    }
}


