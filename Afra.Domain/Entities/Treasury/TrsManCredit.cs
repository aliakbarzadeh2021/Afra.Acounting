using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsManCredit : BaseEntity
    {
          
 
		public Int32 TrsManCreditId { get; set; }  
 
		public Int32 TMCType { get; set; }  
 
		public Int32 TMCCrspndRef { get; set; }  
 
		public Int32 TMCKind { get; set; }  
 
		public Double TMCAmount { get; set; }  
 
		public String TMCDescr { get; set; } 
    }
}


