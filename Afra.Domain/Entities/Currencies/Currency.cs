using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class Currency : BaseEntity
    {
          
 
		public Int32 CurrencyId { get; set; }  
 
		public String CurTitle { get; set; }  
 
		public Nullable<Int32> CurDigitCnt { get; set; }  
 
		public String CurDigitTitle { get; set; } 
    }
}


